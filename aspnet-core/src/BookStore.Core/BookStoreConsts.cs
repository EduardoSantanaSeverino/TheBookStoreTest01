using BookStore.Debugging;

namespace BookStore
{
    public class BookStoreConsts
    {
        public const string LocalizationSourceName = "BookStore";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "542434c8a08a4e4db2146cacaebabc58";
    }
}
