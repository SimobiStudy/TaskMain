using System;
using System.Collections.Generic;
using System.Text;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Task8.Types
{
    [Table("games")]
    public class Game : BaseModel
    {
        [PrimaryKey("id", false)]
        public long? Id { get; set; }

        [Column("user")]
        public string User { get; set; }


        [Column("difficulty")]
        public string PlayedDifficulty { get; set; }

        [Column("is_won")]
        public bool IsWon { get; set; }

        [Column("time_taken")]
        public int TimeTaken { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }
}
