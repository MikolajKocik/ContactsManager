using Microsoft.Extensions.Configuration;
using System.Linq.Expressions;

namespace ContactsManager
{
    internal static class Program
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

            try
            {
                string connectionString = configuration["ConnectionString:Default"]
                    ?? throw new ArgumentNullException("Connection string not found");

                Application.Run(new Form1(connectionString));
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(string.Join(", ", ex.Message));
            }
        }
    }
}