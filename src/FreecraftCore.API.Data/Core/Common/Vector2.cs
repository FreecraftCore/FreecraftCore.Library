using System;
using System.ComponentModel.DataAnnotations.Schema;
using FreecraftCore.Serializer;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace FreecraftCore
{
	/// <summary>
	/// Generic 2-dimensional vector.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	[Owned]
	[WireDataContract]
	public class Vector2<T>
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
					default:
						throw new ArgumentOutOfRangeException($"Index: {index} is out of the bounds of {nameof(Vector4<T>)}");
				}
			}
		}

		/// <inheritdoc />
		public Vector2(T x, T y)
		{
			X = x;
			Y = y;
		}

		public Vector2()
		{

		}

		/// <inheritdoc />
		public override string ToString()
		{
			return $"X: {X} Y: {Y}";
		}
	}
}
