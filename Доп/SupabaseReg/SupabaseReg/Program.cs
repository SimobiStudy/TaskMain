namespace SupabaseReg;

#nullable disable
public class Main_
{
    
    public async static Task Main()
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
        await Master.supabaseClient.InitializeAsync();
        await StartLogin();
    }

    public async static Task StartLogin()
    {
        Console.WriteLine("Вход в аккаунт.");
        bool loginSuccesful = false;
        while (!loginSuccesful){
            Console.WriteLine("Введите Username:");
            var username = Console.ReadLine()?.Trim();
            Console.WriteLine("Введите Password:");
            var password = Console.ReadLine()?.Trim();
            loginSuccesful = await LoginManager.GetLoginResult(username, password);
            if (!loginSuccesful)
                Console.WriteLine("Неверный логин или пароль");
            else
            {
                Console.WriteLine("Успешный вход в аккаунт!");
            }
        }

        Console.ReadKey(true);
    }
}