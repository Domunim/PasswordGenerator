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

            //Application.Run(new LoginForm());

            // test forms
            //Application.Run(new CreateUserForm());
            Application.Run(new GeneratePasswordForm());
            //Application.Run(new UserDeletionConfirmationForm());
            //Application.Run(new LoginForm());
           
        }
    }
}