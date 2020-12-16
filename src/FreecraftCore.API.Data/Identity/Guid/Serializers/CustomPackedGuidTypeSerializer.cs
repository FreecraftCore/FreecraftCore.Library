using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Custom type serializer for <see cref="PackedGuid"/>
	/// </summary>
	public sealed class CustomPackedGuidTypeSerializer : StatelessTypeSerializerStrategy<CustomPackedGuidTypeSerializer, PackedGuid>
	{
		//See Also: https://github.com/TrinityCore/WowPacketParser/blob/5663c555cb560769df23685bf769c08af277f419/WowPacketParser/Misc/PacketReads.cs#L54
		public override PackedGuid Read(Span<byte> buffer, ref int offset)
		{
			//See: https://github.com/jackpoz/BotFarm/blob/592dbc9dbb58c06175bffecfced56eba42107c9a/Client/World/Network/InPacket.cs#L24
			byte mask = BytePrimitiveSerializerStrategy.Instance.Read(buffer, ref offset);

			if(mask == 0)
				return PackedGuid.Empty;

			ulong res = 0;

			int i = 0;
			while(i < 8)
			{
				if((mask & 1 << i) != 0)
					res += ((ulong)BytePrimitiveSerializerStrategy.Instance.Read(buffer, ref offset)) << (i * 8);

				i++;
			}

			return new PackedGuid(res);
		}

		public override void Write(PackedGuid value, Span<byte> buffer, ref int offset)
		{
			//TODO: Can we use span or stackalloc? Or maybe shared buffer?
			byte[] packGuid = GeneratePackedGuid(value, out int size);

			//Must use SIZE cannot just write with primitive array
			for (int i = 0; i < size; i++)
				buffer[i + offset] = packGuid[i];

			offset += size;
		}

		private static byte[] GeneratePackedGuid(PackedGuid value, out int size)
		{
			byte[] packGuid = new byte[8 + 1];

			size = 1;
			ulong guid = value.RawGuidValue;

			for(byte i = 0; guid != 0; ++i)
			{
				if((guid & 0xFF) != 0)
				{
					packGuid[0] |= (byte)(1 << i);
					packGuid[size] = (byte)(guid & 0xFF);
					++size;
				}

				guid >>= 8;
			}

			return packGuid;
		}
	}
}
