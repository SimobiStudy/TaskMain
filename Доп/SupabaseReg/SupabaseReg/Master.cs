using Supabase.Gotrue;
using Supabase.Interfaces;
using Supabase.Realtime;
using Supabase.Storage;

namespace SupabaseReg;

public static class Master
{
    public static ISupabaseClient<User,Session,RealtimeSocket,RealtimeChannel,Bucket,FileObject> supabaseClient;
}