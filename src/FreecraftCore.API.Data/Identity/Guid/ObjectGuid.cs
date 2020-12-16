using System;
using FreecraftCore.Serializer;
using Newtonsoft.Json;


namespace FreecraftCore
{
	//value-type wrapper for the object GUID from Trinitycore
	[WireDataContract]
	public class ObjectGuid : BaseGuid, IEquatable<ObjectGuid>//using a class reduces GC pressure but this object should be treated as a value-type and is immutable
	{
		/// <summary>
		/// Represents an Empty or uninitialized <see cref="ObjectGuid"/>.
		/// </summary>
		[JsonIgnore]
		public static ObjectGuid Empty { get; } = new ObjectGuid(0);

		/// <summary>
		/// GUID value.
		/// </summary>
		[JsonProperty]
		[WireMember(1)]
		public override ulong RawGuidValue { get; internal set; }

		/// <summary>
		/// Creates a new value-type wrapped for the uint64 raw GUID value.
		/// </summary>
		/// <param name="guidValue">Raw GUID value.</param>
		public ObjectGuid(ulong guidValue)
		{
			RawGuidValue = guidValue;
		}

		public ObjectGuid()
		{
			RawGuidValue = 0;
		}

		/// <summary>
		/// Implict cast to ulong (uint64 TC/C++)
		/// </summary>
		/// <param name="guid"></param>
		public static implicit operator ulong(ObjectGuid guid)
		{
			return guid.RawGuidValue;
		}

		/// <summary>
		/// Implict cast to ulong (uint64 TC/C++)
		/// </summary>
		/// <param name="guid"></param>
		public static implicit operator ObjectGuid(ulong guid)
		{
			return new ObjectGuid(guid);
		}

		/// <summary>
		/// Implict cast to from <see cref="PackedGuid"/> to <see cref="ObjectGuid"/>
		/// </summary>
		/// <param name="guid"></param>
		public static implicit operator ObjectGuid(PackedGuid guid)
		{
			return new ObjectGuid(guid.RawGuidValue);
		}

		public bool Equals(ObjectGuid other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return base.Equals(other) && RawGuidValue == other.RawGuidValue;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((ObjectGuid) obj);
		}

		public static bool operator ==(ObjectGuid lhs, ObjectGuid rhs)
		{
			// Check for null on left side.
			if(Object.ReferenceEquals(lhs, null))
			{
				if(Object.ReferenceEquals(rhs, null))
				{
					// null == null = true.
					return true;
				}

				// Only the left side is null.
				return false;
			}


			// Equals handles case of null on right side.
			return lhs.Equals(rhs);
		}

		public static bool operator !=(ObjectGuid lhs, ObjectGuid rhs)
		{
			return !(lhs == rhs);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (base.GetHashCode() * 397) ^ RawGuidValue.GetHashCode();
			}
		}
	}
}
