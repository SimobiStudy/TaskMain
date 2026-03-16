using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace SupabaseReg.Types.DatabaseTypes;

[Table("users")]
public class User : BaseModel
{
    [PrimaryKey("username", false)]
    [Column("username")]
    public string Username { get; set; }
    
    [Column("password")]
    public string Password { get; set; }
}