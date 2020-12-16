using System;
using System.Diagnostics;
using System.Linq;
using FreecraftCore;
using FreecraftCore.Serializer;

namespace DynamicProxy.GamePacketPayload.PerformanceTests
{
	class Program
	{
		static void Main(string[] args)
		{
			Stopwatch stopWatch = new Stopwatch();
			SerializerService serializer = new SerializerService();
			stopWatch.Start();
			Type[] dynamicProxies = GamePacketMetadataMarker.GenerateDynamicProxyTemporaryDTOTypes(new Type[0]).ToArray();

			foreach(Type t in dynamicProxies)
			{
				//Console.WriteLine($"Registering: {t.Name}");
			}
			stopWatch.Stop();

			Console.WriteLine($"Finished ms: {stopWatch.ElapsedMilliseconds}");
			Console.ReadKey();
		}
	}
}
