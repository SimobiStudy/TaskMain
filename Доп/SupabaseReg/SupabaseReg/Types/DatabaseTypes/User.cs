using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace SupabaseReg.Types.DatabaseTypes;

[Table("users")]
public class User : BaseModel
{
    [PrimaryKey("username")]
    public string Username { get; set; }
    
    [Column("password")]
    public string Password { get; set; }
}