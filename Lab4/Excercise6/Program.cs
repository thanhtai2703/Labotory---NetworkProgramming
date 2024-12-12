namespace Excercise6
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LogIn());
        }
    }
    public class User
    {
        private static User _instance;
        public string TokenType;
        public string AccessToken;
        private User() { }
        public static User Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new User();
                return _instance;
            }
        }
    }

}