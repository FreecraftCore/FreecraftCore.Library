using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Realm identifiers
	/// </summary>
	[WireDataContract]
	public class RealmIdentification
	{
		//Probably used to verify the correct realm has been connected to
		[WireMember(7)]
		internal uint RegionID { get; set; } = 0;

		//Probably used to verify the correct realm has been connected to
		[WireMember(8)]
		internal uint BattlegroupID { get; set; } = 0;

		//Unused by Trinitycore aside from
		//assigning to the database
		/// <summary>
		/// Indicates the realm that was selected.
		/// </summary>
		[WireMember(9)]
		public uint RealmID { get; internal set; }

		/// <summary>
		/// Creates a new realm identification object
		/// with the provided <see cref="RealmID"/>
		/// </summary>
		/// <param name="realmId">The ID of the realm.</param>
		public RealmIdentification(uint realmId)
		{
			RealmID = realmId;
		}

		public RealmIdentification()
		{
			
		}
	}
}
