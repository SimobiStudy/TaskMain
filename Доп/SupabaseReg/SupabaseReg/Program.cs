namespace SupabaseReg;

#nullable disable
public class Main_
{
    
    public static void Main()
    {
        Console.WriteLine("Check");
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

        var mainForm = new Form1();
        Application.Run(mainForm);
    }
    
}