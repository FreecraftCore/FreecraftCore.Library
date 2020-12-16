using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FreecraftCore.Serializer;
using Reinterpret.Net;

namespace FreecraftCore
{
	public sealed class LinearPathMoveInfoTypeSerializer : StatelessTypeSerializerStrategy<LinearPathMoveInfoTypeSerializer, LinearPathMoveInfo>
	{
		public override LinearPathMoveInfo Read(Span<byte> buffer, ref int offset)
		{
			int lastIndex = GenericTypePrimitiveSerializerStrategy<int>.Instance.Read(buffer, ref offset);

			float lastPointX = GenericTypePrimitiveSerializerStrategy<float>.Instance.Read(buffer, ref offset);
			float lastPointY = GenericTypePrimitiveSerializerStrategy<float>.Instance.Read(buffer, ref offset);
			float lastPointZ = GenericTypePrimitiveSerializerStrategy<float>.Instance.Read(buffer, ref offset);

			Vector3<float> lastPoint = new Vector3<float>(lastPointX, lastPointY, lastPointZ);

			/*// can be used in SMSG_MONSTER_MOVE opcode
			void appendPackXYZ(float x, float y, float z)
			{
				uint32 packed = 0;
				packed |= ((int)(x / 0.25f) & 0x7FF);
				packed |= ((int)(y / 0.25f) & 0x7FF) << 11;
				packed |= ((int)(z / 0.25f) & 0x3FF) << 22;
				*this << packed;
			}*/

			/*G3D::Vector3 middle = (real_path[0] + real_path[last_idx]) / 2.f;
			G3D::Vector3 offset;
			// first and last points already appended
			for (uint32 i = 1; i < last_idx; ++i)
			{
				offset = middle - real_path[i];
				data << TaggedPosition<Position::PackedXYZ>(offset.x, offset.y, offset.z);
			}*/
			Vector3<float>[] middlePoints = new Vector3<float>[lastIndex - 1];
			if(lastIndex > 1)
			{
				for(int i = 1; i < lastIndex; ++i)
				{
					int packedFloats = GenericTypePrimitiveSerializerStrategy<int>.Instance.Read(buffer, ref offset);

					float x = ((packedFloats & 0x7FF) << 21 >> 21) * 0.25f;
					float y = ((((packedFloats >> 11) & 0x7FF) << 21) >> 21) * 0.25f;
					float z = ((packedFloats >> 22 << 22) >> 22) * 0.25f;

					middlePoints[i - 1] = new Vector3<float>(x, y, z);
				}
			}

			return new LinearPathMoveInfo(lastIndex, lastPoint, middlePoints);
		}

		public override void Write(LinearPathMoveInfo value, Span<byte> buffer, ref int offset)
		{
			if(value == null)
				return;

			GenericTypePrimitiveSerializerStrategy<int>.Instance.Write(value.LastIndex, buffer, ref offset);

			GenericTypePrimitiveSerializerStrategy<float>.Instance.Write(value.FinalPosition.X, buffer, ref offset);
			GenericTypePrimitiveSerializerStrategy<float>.Instance.Write(value.FinalPosition.Y, buffer, ref offset);
			GenericTypePrimitiveSerializerStrategy<float>.Instance.Write(value.FinalPosition.Z, buffer, ref offset);

			if (value.LastIndex > 1 && value.SplineMiddlePoints != null)
				throw KnownIncompleteSerializationException.Create<LinearPathMoveInfo>($"TODO: Implement mid points writing.");
		}
	}
}
