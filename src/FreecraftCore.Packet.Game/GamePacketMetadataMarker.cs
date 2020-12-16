using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading.Tasks;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Type marker for the game packet assembly.
	/// </summary>
	public static class GamePacketMetadataMarker
	{
		public static IReadOnlyCollection<Type> GamePacketPayloadTypes { get; }

		public static IReadOnlyCollection<Type> SerializableTypes { get; }

		public static IReadOnlyCollection<Type> AssemblyTypes { get; }

		public static Lazy<IReadOnlyCollection<Type>> GamePacketPayloadTypesWithDynamicProxies { get; }

		public static Lazy<IReadOnlyCollection<NetworkOperationCode>> UnimplementedOperationCodes { get; }

		/// <summary>
		/// The backing field name for the dynamic proxy DTOs.
		/// </summary>
		public static string DynamicProxyDataBackingFieldName { get; } = "Data_backingfield";

		static GamePacketMetadataMarker()
		{
			AssemblyTypes = typeof(GamePacketMetadataMarker)
				.Assembly
				.GetExportedTypes();

			GamePacketPayloadTypes = AssemblyTypes
				.Where(t => typeof(GamePacketPayload).IsAssignableFrom(t))
				.ToArray();

			SerializableTypes = GamePacketPayloadTypes
				.Concat(AssemblyTypes.Where(t => t.GetCustomAttribute<WireDataContractAttribute>() != null))
				.Distinct()
				.ToArray();

			GamePacketPayloadTypesWithDynamicProxies = new Lazy<IReadOnlyCollection<Type>>(() => GamePacketPayloadTypes
				.Concat(GenerateDynamicProxyTemporaryDTOTypes(GamePacketPayloadTypes))
				.ToArray(), true);

			UnimplementedOperationCodes = new Lazy<IReadOnlyCollection<NetworkOperationCode>>(() =>
			{
				var codes = GamePacketPayloadTypes
					.Where(t => t.GetCustomAttribute<GamePayloadOperationCodeAttribute>(true) != null)
					.Select(t => t.GetCustomAttribute<GamePayloadOperationCodeAttribute>(true).OperationCode)
					.Distinct()
					.ToArray();

				return ((NetworkOperationCode[])Enum.GetValues(typeof(NetworkOperationCode)))
					.Where(o => !codes.Contains(o))
					.ToArray();
			}, true);
		}

		public static IEnumerable<Type> GenerateDynamicProxyTemporaryDTOTypes(IEnumerable<Type> implementedPacketTypes)
		{
			var an = new AssemblyName("FreecraftCore.Packet.Game.Dynamic");
			AssemblyBuilder assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(an, AssemblyBuilderAccess.Run);
			ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("Proxy");

			ConstructorInfo opCodeAttributeCtor = typeof(GamePayloadOperationCodeAttribute).GetTypeInfo().DeclaredConstructors.First(c => c.GetParameters().Any(p => p.ParameterType == typeof(NetworkOperationCode)));
			ConstructorInfo wireDataContractAttributeCtor = typeof(WireDataContractAttribute).GetTypeInfo().DeclaredConstructors.First(c => c.GetParameters().Length == 3);
			ConstructorInfo readToEndAttributeCtor = typeof(ReadToEndAttribute).GetTypeInfo().DeclaredConstructors.First();
			ConstructorInfo wireMemberAttributeCtor = typeof(WireMemberAttribute).GetTypeInfo().DeclaredConstructors.First(c => c.GetParameters().Length > 0);

			object[] wireDataContractAttribute = new object[0] { };
			CustomAttributeBuilder wireDataContractAttributeBuilder = new CustomAttributeBuilder(wireDataContractAttributeCtor, wireDataContractAttribute);
			CustomAttributeBuilder readToEndAttributeBuilder = new CustomAttributeBuilder(readToEndAttributeCtor, new object[0]);
			CustomAttributeBuilder wireMemberAttributeBuilder = new CustomAttributeBuilder(wireMemberAttributeCtor, new object[1] {1});
			ConcurrentBag<Type> types = new ConcurrentBag<Type>();

			Parallel.ForEach(UnimplementedOperationCodes.Value, opcode =>
			{
				TypeBuilder tb = GetProxyDTOTypeBuilder($"{opcode.ToString()}_ProxyDTO", moduleBuilder);

				//KeyType keyType = KeyType.None, InformationHandlingFlags typeHandling = InformationHandlingFlags.Default, bool expectRuntimeLink = false
				
				object[] attributeArguments = new object[] { opcode };

				tb.SetCustomAttribute(new CustomAttributeBuilder(opCodeAttributeCtor, attributeArguments));
				tb.SetCustomAttribute(wireDataContractAttributeBuilder);

				FieldBuilder fieldBuilder = tb.DefineField(DynamicProxyDataBackingFieldName, typeof(byte[]), FieldAttributes.Public);

				fieldBuilder.SetCustomAttribute(readToEndAttributeBuilder);
				fieldBuilder.SetCustomAttribute(wireMemberAttributeBuilder);


				//Default ctor
				tb.DefineDefaultConstructor(MethodAttributes.Public);

				tb.AddInterfaceImplementation(typeof(IUnimplementedGamePacketPayload));
				BuildDataProperty(tb, fieldBuilder);

				types.Add(tb.CreateTypeInfo().AsType());
			});

			return types;
		}

		internal static MethodAttributes GetSetMethodAttributes { get; } = MethodAttributes.Public | MethodAttributes.HideBySig
			| MethodAttributes.SpecialName | MethodAttributes.Virtual;

		internal static Type[] GetSetParameters { get; } = new Type[1] { typeof(byte[]) };

		//From: https://stackoverflow.com/questions/5277291/implementing-interface-at-run-time-get-value-method-not-implemented?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa
		private static void BuildDataProperty(TypeBuilder typeBuilder, FieldBuilder backingField)
		{
			PropertyBuilder propertyBuilder = typeBuilder.DefineProperty(nameof(IUnimplementedGamePacketPayload.Data), PropertyAttributes.None, typeof(byte[]), null);

			MethodBuilder getter = typeBuilder.DefineMethod($"get_{nameof(IUnimplementedGamePacketPayload.Data)}", GetSetMethodAttributes, typeof(byte[]), Type.EmptyTypes);

			ILGenerator getIL = getter.GetILGenerator();
			getIL.Emit(OpCodes.Ldarg_0);
			getIL.Emit(OpCodes.Ldfld, backingField);
			getIL.Emit(OpCodes.Ret);

			MethodBuilder setter = typeBuilder.DefineMethod($"set_{nameof(IUnimplementedGamePacketPayload.Data)}", GetSetMethodAttributes, null, GetSetParameters);

			ILGenerator setIL = setter.GetILGenerator();
			setIL.Emit(OpCodes.Ldarg_0);
			setIL.Emit(OpCodes.Ldarg_1);
			setIL.Emit(OpCodes.Stfld, backingField);
			setIL.Emit(OpCodes.Ret);


			propertyBuilder.SetGetMethod(getter);
			propertyBuilder.SetSetMethod(setter);
		}

		private static TypeBuilder GetProxyDTOTypeBuilder(string typeName, ModuleBuilder moduleBuilder)
		{
			TypeBuilder tb = moduleBuilder.DefineType(typeName,
				TypeAttributes.Public |
				TypeAttributes.Class |
				TypeAttributes.AutoClass |
				TypeAttributes.AnsiClass |
				TypeAttributes.BeforeFieldInit |
				TypeAttributes.AutoLayout,
				typeof(GamePacketPayload));

			return tb;
		}
	}
}
