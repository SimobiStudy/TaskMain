using System.CodeDom.Compiler;
using Supabase.Postgrest;
using Supabase.Storage;
using SupabaseReg.Types.DatabaseTypes;

namespace SupabaseReg;

public static class LoginManager
{
    public async static Task<User> GetLoginResult(string username, string password)
    {
        var getLogins = await Master.supabaseClient
            .From<User>()
            //.Filter("username", Constants.Operator.Equals, username)
            .Get();

        if (!getLogins.Models.Any())
        {
            return null;
        }

        foreach (var model in  getLogins.Models)
        {
            if (model.Username == username && model.Password == password)
            {
                Master.currentUser = model;
                return model;
            }
        }

        return null;
    }

    public async static Task<User> RegisterNewUser(string username, string password)
    {
        if (username == null)
            throw new ArgumentNullException(nameof(username));
        var user = new User()
        {
            Username = username,
            Password = password,
        };
        var res = await Master.supabaseClient.From<User>().Insert(user);
        return res.Model;
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
            .Upload(filePath, user.Username + "-avatar.png");
    }
    
    public async static Task<string> GetAvatarFile(User user)
    {
        if (!(await CheckBucketExistance("avatars")))
        {
            return null;
        }

        var bytes = await Master.supabaseClient.Storage.From("avatars").Download(user.Username + "-avatar.png", new TransformOptions());
        
        string tempFile = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName()));
        await File.WriteAllBytesAsync(tempFile, bytes);
        return tempFile;
    }
}