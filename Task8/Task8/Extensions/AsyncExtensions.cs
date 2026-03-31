namespace SupabaseReg.Extensions;

public static class AsyncExtensions
{
    public static TResult ResultSync<TResult>(this Task<TResult> task)
    {
        return task.GetAwaiter().GetResult();
    }
}