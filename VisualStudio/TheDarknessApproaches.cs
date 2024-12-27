global using ComplexLogger;

namespace TheDarknessApproaches
{
	/// <inheritdoc/>
	public class Main : MelonMod
	{
		internal static ComplexLogger<Main> Logger { get; } = new();
		/// <summary>
		/// This is just a bunch of startup messages to send to the log. Meant to be part of the psychological horror
		/// </summary>
		internal static List<string> StartupMessages { get; } =
		[
			"The player has chosen Death, and Death has never been shy.",
			"A light has been turned on. How long will it last?"
		];
		internal static int TheChosenOne { get; set; } = 0;
		/// <inheritdoc/>
		public override void OnInitializeMelon()
		{
			System.Random rnd = new();
			TheChosenOne = rnd.Next(0, StartupMessages.Count);
			Logger.Log(StartupMessages[TheChosenOne], FlaggedLoggingLevel.Always);
		}
	}

	[RegisterTypeInIl2Cpp(false)]
	public class PsychologicalHorrorComponent : MonoBehaviour
	{
		public PsychologicalHorrorComponent() { }
		public PsychologicalHorrorComponent(IntPtr pointer) : base(pointer) { }

		public void Awake()
		{

		}
		public void LateUpdate()
		{

		}
	}
}
namespace TheDarknessApproaches.AK
{
	public class EVENTS
	{
		/* 
		Look at Il2CppAK.EVENTS
		Standards:
		- All event names must be fully capitalized
		- Play sounds should start with PLAY_
		- Stop sounds start with STOP_
		- Stinger sounds start with STINGER_
		- Every name must be as detailed as possible. These names CANT be changed
		*/
		public static string PLAY_ = "";
	}
}