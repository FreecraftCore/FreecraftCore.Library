using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreecraftCore.Serializer;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace FreecraftCore
{
	[Owned]
	[WireDataContract]
	public class Vector3<T>// : Vector2<T> TODO: For compatibility with EF Core owned types we cannot use inheritence
	{
		/// <summary>
		/// X value.
		/// </summary>
		[WireMember(1)]
		public T X { get; internal set; }

		/// <summary>
		/// Y value.
		/// </summary>
		[WireMember(2)]
		public T Y { get; internal set; }

		/// <summary>
		/// Z value.
		/// </summary>
		[WireMember(3)]
		public T Z { get; internal set; }

		[JsonIgnore]
		[NotMapped]
		public T this[int index]
		{
			get
			{
				switch(index)
				{
					case 0:
						return X;
					case 1:
						return Y;
					case 2:
						return Z;
					default:
						throw new ArgumentOutOfRangeException($"Index: {index} is out of the bounds of {nameof(Vector4<T>)}");
				}
			}
		}

		public Vector3(T x, T y, T z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public Vector3()
		{

		}

		/// <inheritdoc />
		public override string ToString()
		{
			return $"X: {X} Y: {Y} Z: {Z}";
		}
	}
}
