using System.CodeDom.Compiler;
using Supabase.Gotrue;
using Supabase.Postgrest;
using Supabase.Storage;


namespace SupabaseReg;

public static class LoginManager
{
    public async static Task<User> LoginToUser(string email, string password)
    {

        var login = await Master.supabaseClient.Auth.SignIn(email, password);
        if (login == null)
            return null;
        return login.User;
    }

    public async static Task<User> RegisterNewUser(string email, string password)
    {
        var session = await Master.supabaseClient.Auth.SignUp(email, password);
        if (session == null)
            throw new Exception("Registration failed, please disable Confirm user in project settings");
        if (session.User == null)
            return null!;
        return session.User;
    }

    public async static Task<bool> CheckBucketExistance(string bucketName)
    {
        var buckets = await Master.supabaseClient.Storage.ListBuckets();
        return buckets.Any(x => x.Name == bucketName);
    }

    public async static Task CreateNewBucket(string bucketName)
    {
        await Master.supabaseClient.Storage.CreateBucket(bucketName, new BucketUpsertOptions(){Public = true});
    }

    public async static Task<Bucket> GetBucket(string bucketName)
    {
        return await Master.supabaseClient.Storage.GetBucket(bucketName);
    }
    
    public async static Task UploadAvatar(string filePath, User user)
    {
        if (!(await CheckBucketExistance("avatars")))
        {
            await Master.supabaseClient.Storage.CreateBucket("avatars");
        }

        await Master.supabaseClient.Storage
            .From("avatars")
            .Upload(filePath, user.Id + "-avatar.png");
    }
    
    public async static Task<string> GetAvatarFile(User user)
    {
        if (!(await CheckBucketExistance("avatars")))
        {
            return null;
        }

        var bytes = await Master.supabaseClient.Storage.From("avatars").Download(user.Id + "-avatar.png", new TransformOptions());
        
        string tempFile = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName()));
        await File.WriteAllBytesAsync(tempFile, bytes);
        return tempFile;
    }
}