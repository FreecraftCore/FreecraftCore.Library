using System;
using System.Collections.Generic;
using System.Text;
using FreecraftCore.Serializer;

namespace FreecraftCore
{
	[WireDataContract]
	public sealed class QuestGreeting
	{
		//Nullterminated string.
		[Encoding(EncodingType.ASCII)]
		[WireMember(2)]
		public string GreetingText { get; internal set; }

		//TODO: What is this??
		[WireMember(3)]
		public int GreetingDelay { get; internal set; }

		/// <summary>
		/// See: Emotes DBC.
		/// </summary>
		[WireMember(4)]
		public int GreetingEmoteType { get; internal set; }

		public QuestGreeting(string greetingText, int greetingDelay, int greetingEmoteType)
		{
			GreetingText = greetingText;
			GreetingDelay = greetingDelay;
			GreetingEmoteType = greetingEmoteType;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public QuestGreeting()
		{
			
		}
	}
}
