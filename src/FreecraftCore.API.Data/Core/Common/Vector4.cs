using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
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
	public class Vector4<T>// : Vector3<T> TODO: For compatibility with EF Core owned types we cannot use inheritence
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

		/// <summary>
		/// X value.
		/// </summary>
		[WireMember(4)]
		public T W { get; internal set; }

		[JsonIgnore]
		[NotMapped]
		public T this[int index]
		{
			get
			{
				switch (index)
				{
					case 0:
						return X;
					case 1:
						return Y;
					case 2:
						return Z;
					case 3:
						return W;
					default:
						throw new ArgumentOutOfRangeException($"Index: {index} is out of the bounds of {nameof(Vector4<T>)}");
				}
			}
		}

		public Vector4(T x, T y, T z, T w)
		{
			X = x;
			Y = y;
			Z = z;
			W = w;
		}

		public Vector4()
		{

		}

		/// <inheritdoc />
		public override string ToString()
		{
			return $"X: {X} Y: {Y} Z: {Z} W: {W}";
		}
	}
}
