namespace telegrambotgroupagree {
	public static class Globals {
    //We have three configurations to compile the bot: As local test, nightly or release
    //To test the bot locally you need to provide the 
		public static string Botname =
    //Use only the name prefix, for example groupagree instead of groupagreebot
    //Put your bot's names in here
		#if DEBUG
			"testing"
		#elif NIGHTLY
			""
		#elif RELEASE
			""
    #endif
      ;

		public static string Apikey = 
    //Add your API-Keys here
			#if DEBUG
			""
			#elif NIGHTLY
			""
			#elif RELEASE
			""
			#endif
			;
		}
}
