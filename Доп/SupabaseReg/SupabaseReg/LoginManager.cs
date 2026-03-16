using Supabase.Postgrest;
using SupabaseReg.Types.DatabaseTypes;

namespace SupabaseReg;

public static class LoginManager
{
    public async static Task<bool> GetLoginResult(string username, string password)
    {
        var getLogins = await Master.supabaseClient
            .From<User>()
            .Filter("username", Constants.Operator.Equals, username)
            .Get();

        if (!getLogins.Models.Any())
        {
            return false;
        }

        foreach (var model in  getLogins.Models)
        {
            return model.Username ==  username &&  model.Password == password;
        }

        return false;
    }

    public async static Task<User> RegisterNewUser(string username, string password)
    {
        var user = new User()
        {
            Username = username,
            Password = password,
        };
        
        var res = await  Master.supabaseClient.From<User>().Insert(user);
        return res == null! ? res.Model : null;
    }
}