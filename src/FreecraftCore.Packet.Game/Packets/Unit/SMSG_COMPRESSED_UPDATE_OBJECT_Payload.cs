﻿using System;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// The compressed version of <see cref="NetworkOperationCode.SMSG_UPDATE_OBJECT"/>.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_COMPRESSED_UPDATE_OBJECT)]
	public sealed class SMSG_COMPRESSED_UPDATE_OBJECT_Payload : GamePacketPayload, IObjectUpdatePayload
	{
		//Compressed update object just uses the regular compression in WoW
		/// <summary>
		/// The update blocks.
		/// </summary>
		[Compress]
		[WireMember(1)]
		public UpdateBlockCollection UpdateBlocks { get; }

		public SMSG_COMPRESSED_UPDATE_OBJECT_Payload([NotNull] UpdateBlockCollection updateBlocks)
		{
			UpdateBlocks = updateBlocks ?? throw new ArgumentNullException(nameof(updateBlocks));
		}

		protected SMSG_COMPRESSED_UPDATE_OBJECT_Payload()
		{
			
		}
	}
}