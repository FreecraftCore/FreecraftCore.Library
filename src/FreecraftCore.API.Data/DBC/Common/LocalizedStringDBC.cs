using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace FreecraftCore
{
	[Owned]
	[WireDataContract]
	public sealed class LocalizedStringDBC<TStringType>
	{
		//This might seem ridiclous that we don't use arrays BUT EF does not support arrays
		//for the models so we MUST use seperate fields.
		/// <summary>
		/// The EN-US localization.
		/// </summary>
		[WireMember(1)]
		public TStringType enUS { get; internal set; }

		[NotMapped]
		[JsonIgnore]
		public TStringType enGB => enUS;

		[WireMember(2)]
		public TStringType koKR { get; internal set; }

		[WireMember(3)]
		public TStringType frFR { get; internal set; }

		[WireMember(4)]
		public TStringType deDE { get; internal set; }

		[WireMember(5)]
		public TStringType enCN { get; internal set; }

		[NotMapped]
		[JsonIgnore]
		public TStringType zhCN => enCN;

		[WireMember(6)]
		public TStringType enTW { get; internal set; }

		[NotMapped]
		[JsonIgnore]
		public TStringType zhTW => enTW;

		[WireMember(7)]
		public TStringType esES { get; internal set; }

		[WireMember(8)]
		public TStringType esMX { get; internal set; }

		[WireMember(9)]
		public TStringType ruRU { get; internal set; }

		[NotMapped]
		[JsonIgnore]
		[WireMember(10)]
		public TStringType Unknown1 { get; internal set; }

		[WireMember(11)]
		public TStringType ptPT { get; internal set; }

		[NotMapped]
		[JsonIgnore]
		public TStringType ptBR => ptPT;

		[WireMember(12)]
		public TStringType itIT { get; internal set; }

		//The below fields are read but are unknown
		/// <summary>
		/// Unknown field values.
		/// Leave these as default values.
		/// Do not write anything for them.
		/// </summary>
		[JsonIgnore]
		[NotMapped]
		[KnownSize(4)]
		[WireMember(13)]
		public TStringType[] Unknowns { get; internal set; } = new TStringType[4];

		/// <summary>
		/// 4 byte bitmask for the localized string.
		/// TODO: What is this? Does it need to be set?
		/// </summary>
		[WireMember(14)]
		public uint Flags { get; internal set; }

		/// <inheritdoc />
		public LocalizedStringDBC(TStringType enUs, TStringType koKr, TStringType frFr, TStringType deDe, TStringType enCn, TStringType enTw, TStringType esEs, TStringType esMx, TStringType ruRu, TStringType unknown1, TStringType ptPt, TStringType itIt, uint flags)
		{
			enUS = enUs;
			koKR = koKr;
			frFR = frFr;
			deDE = deDe;
			enCN = enCn;
			enTW = enTw;
			esES = esEs;
			esMX = esMx;
			ruRU = ruRu;
			Unknown1 = unknown1;
			ptPT = ptPt;
			itIT = itIt;
			Flags = flags;
		}

		/// <inheritdoc />
		public LocalizedStringDBC(TStringType enUs, TStringType koKr, TStringType frFr, TStringType deDe, TStringType enCn, TStringType enTw, TStringType esEs, TStringType esMx, TStringType ruRu, TStringType unknown1, TStringType ptPt, TStringType itIt, uint flags, [NotNull] TStringType[] unknowns)
		{
			if(Unknowns.Length != 4)
				throw new ArgumentException($"Unknown localization strings MUST be 4 in length.", nameof(unknowns));

			enUS = enUs;
			koKR = koKr;
			frFR = frFr;
			deDE = deDe;
			enCN = enCn;
			enTW = enTw;
			esES = esEs;
			esMX = esMx;
			ruRU = ruRu;
			Unknown1 = unknown1;
			ptPT = ptPt;
			itIT = itIt;
			Flags = flags;
			Unknowns = unknowns ?? throw new ArgumentNullException(nameof(unknowns));
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public LocalizedStringDBC()
		{

		}
	}
}
