using SupabaseReg;

namespace Task8
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string url, key;
            try
            {
                url = Environment.GetEnvironmentVariable("SUPABASE_URL")!;
                key = Environment.GetEnvironmentVariable("SUPABASE_KEY")!;
            }
            catch
            {
                Console.WriteLine("Не введены переменные среды");
                Console.ReadKey();
                return;
            }
            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };
            Master.supabaseClient = new Supabase.Client(url, key, options);
            Master.supabaseClient.InitializeAsync().GetAwaiter().GetResult();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}