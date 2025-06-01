using Microsoft.Extensions.Configuration;

namespace ContactsManager
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var builder = new ConfigurationBuilder()
                .AddUserSecrets(typeof(Program).Assembly);

            IConfiguration configuration = builder.Build();
            string connectionString = configuration["ConnectionStrings:Default"] 
                ?? string.Empty;

            if (connectionString is null)
                throw new ArgumentNullException();

                Application.Run(new Form1(connectionString));
        }
    }
}