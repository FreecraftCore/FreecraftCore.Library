using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using FreecraftCore.Serializer;
using Reinterpret.Net;

namespace FreecraftCore
{
	/// <summary>
	/// The custom FrecraftCore type serializer for the update field collection
	/// type.
	/// </summary>
	public sealed class CustomUpdateFieldCollectionTypeSerializer : StatelessTypeSerializerStrategy<CustomUpdateFieldCollectionTypeSerializer, UpdateFieldValueCollection>
	{
		public override UpdateFieldValueCollection Read(Span<byte> buffer, ref int offset)
		{
			//Update fields are sent with an inital byte size
			byte size = BytePrimitiveSerializerStrategy.Instance.Read(buffer, ref offset);

			if(size == 0)
				return new UpdateFieldValueCollection(new WireReadyBitArray(0), Array.Empty<byte>());

			//TODO: Reduce allocation somehow.
			byte[] bytes = buffer.Slice(offset, size * sizeof(int)).ToArray();
			offset += size * sizeof(int);

			WireReadyBitArray mask = new WireReadyBitArray(bytes);

			//We know how many bytes the bitarray is suppose to be
			//but to know how many values are read we need to compute the bit size
			int updateValueSize = GetCardinality(mask.InternalArray);

			AssertSizeIsCorrect(mask, updateValueSize);

			//TODO: Reduce allocations somehow.
			//Once we have the mask AND the bytes we can construct the update values
			byte[] updateValueBytes = buffer.Slice(offset, updateValueSize * sizeof(int)).ToArray();
			offset += updateValueSize * sizeof(int);

			return new UpdateFieldValueCollection(mask, updateValueBytes);
		}

		public override void Write(UpdateFieldValueCollection value, Span<byte> buffer, ref int offset)
		{
			throw KnownIncompleteSerializationException.Create<UpdateFieldValueCollection>($"TODO: Reimplement UpdateCollection write.");
			/*//TODO: Major performance gains if we can avoid allocations here. MAJOR!!
			//The size must be equal to the length divided by 8 bits (1 byte) but we do not include the
			//remainder from a modular division. The reason for this is it's always sent as 4 byte chunks from
			//Trinitycore and the size is always in terms of an int array
			byte[] bitmask = new byte[value.UpdateMask.Length / 8];

			((ICollection)value.UpdateMask).CopyTo(bitmask, 0);

			byte size = (byte)(bitmask.Length / sizeof(int));

			//Write the size as if it were an int array first
			dest.Write(size);

			dest.Write(bitmask);

			//We must also write the update values
			dest.Write(value.UpdateDiffValues);*/
		}

		[Conditional("DEBUG")]
		private static void AssertSizeIsCorrect(WireReadyBitArray mask, int updateValueSize)
		{
			int count = 0;
			for(int i = 0; i < mask.Length; i++)
				if(mask[i])
					count++;

			if(updateValueSize != count)
				throw new InvalidOperationException($"Failed Standford: {updateValueSize} i: {count}");
		}

		//See: http://graphics.stanford.edu/~seander/bithacks.html#CountBitsSetParallel
		public static Int32 GetCardinality(byte[] bitArray)
		{
			Int32 count = 0;

			unsafe
			{
				fixed (byte* bPtr = &bitArray[0])
				{
					for(Int32 i = 0; i < bitArray.Length / 4; i++)
					{
						//TODO: Is this faster than Unsafe.IL or Reinterpret.NET?
						Int32 c = *(((int*)bPtr) + i);

						// magic (http://graphics.stanford.edu/~seander/bithacks.html#CountBitsSetParallel)
						unchecked
						{
							c = c - ((c >> 1) & 0x55555555);
							c = (c & 0x33333333) + ((c >> 2) & 0x33333333);
							c = ((c + (c >> 4) & 0xF0F0F0F) * 0x1010101) >> 24;
						}

						count += c;

					}
				}
			}

			return count;
		}
	}
}
