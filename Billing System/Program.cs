using BillingSystem.Database;

namespace Billing_System
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

            Application.EnableVisualStyles();  
            Application.SetCompatibleTextRenderingDefault(false);


            StartAppAsync();

            Application.Run();

        }

        private static async void StartAppAsync()
        {
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.Show();

            bool connectionSuccessful = DatabaseConnection.TestConnection();

            Task dbCheck = Task.Run(() =>
            {
                try
                {
                    using (var connection = DatabaseConnection.GetConnection())
                    {
                        connection.Open();
                        // Connection successful, proceed with the application
                        connectionSuccessful = true;
                    }
                }
                catch (Exception)
                {
                    connectionSuccessful = false;
                }
            });

            Task minDelay = Task.Delay(2500); // Minimum display time for the splash screen

            await Task.WhenAll(dbCheck, minDelay);

            splashScreen.Close();
            splashScreen.Dispose();

            if (connectionSuccessful)
            {
                //MessageBox.Show(
                //    "Connected to the database successfully.",
                //    "Database Connection",
                //    MessageBoxButtons.OK,
                //    MessageBoxIcon.Information);

                LoginForm loginForm = new LoginForm();

                loginForm.FormClosed += (s, args) => Application.Exit();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show(
                    "Cannot connect to the database.\n\n" +
                    "Please make sure:\n" +
                    "  1. MySQL Server is running.\n" +
                    "  2. BillingDB database exists.\n" +
                    "  3. The password in DatabaseConnection.cs is correct.",
                    "Database Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Application.Exit();
            }
        }
    }
}