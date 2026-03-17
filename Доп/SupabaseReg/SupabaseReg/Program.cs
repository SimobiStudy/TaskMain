namespace SupabaseReg;

#nullable disable
public class Main_
{
    [STAThread]
    public static void Main()
    {
        Console.WriteLine("Check");
        string url, key, email, password;
        try
        {
            url = Environment.GetEnvironmentVariable("SUPABASE_URL")!;
            key = Environment.GetEnvironmentVariable("SUPABASE_KEY")!;
            email = Environment.GetEnvironmentVariable("SUPABASE_EMAIL")!;
            password = Environment.GetEnvironmentVariable("SUPABASE_PASS")!;
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
        Master.supabaseClient.Auth.SignIn(email, password).GetAwaiter().GetResult();
        var mainForm = new MainForm();
        Application.Run(mainForm);
    }
    
}