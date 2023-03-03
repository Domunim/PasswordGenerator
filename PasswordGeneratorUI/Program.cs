namespace PasswordGeneratorUI
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

            PasswordGeneratorLibrary.TextFileConnector txtConnector = new();

            //Application.Run(new LoginForm()); - final start form
            Application.Run(new CreateUserForm()); // test form
        }
    }
}