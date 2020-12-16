using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore
{
	/// <summary>
	/// Sent by the server to update the client's
	/// action bindings.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_ACTION_BUTTONS)]
	public sealed partial class SMSG_ACTION_BUTTONS_Payload : GamePacketPayload
	{
		public enum State : byte
		{
			Initial,
			Swapping,
			Clear
		}

		[WireMember(1)]
		public State ActionBarUpdateState { get; internal set; }

		public bool HasBindingData => ActionBarUpdateState != State.Clear;

		//TC says this is MAX_ACTION_BUTTONS
		[Optional(nameof(HasBindingData))]
		[KnownSize(144)]
		[WireMember(2)]
		internal ActionButtonData[] _ButtonData { get; set; }

		/// <summary>
		/// The binding/button data collection.
		/// </summary>
		public IReadOnlyCollection<ActionButtonData> ButtonData => _ButtonData;

		//TODO: Validate data
		/// <inheritdoc />
		public SMSG_ACTION_BUTTONS_Payload(State actionBarUpdateState, [NotNull] ActionButtonData[] buttonData)
			: this()
		{
			ActionBarUpdateState = actionBarUpdateState;
			_ButtonData = buttonData ?? throw new ArgumentNullException(nameof(buttonData));
		}

		public SMSG_ACTION_BUTTONS_Payload()
			: base(NetworkOperationCode.SMSG_ACTION_BUTTONS)
		{
			
		}
	}
}
