using System;
using System.Collections.Generic;
using System.Text;
using Supabase.Postgrest;
using SupabaseReg;
using Task8.Types;

namespace Task8
{
    public static class GameGetterHelper
    {
        public static async Task<List<Game>> GetGameList(string selector)
        {
            if(selector == "All")
                return (await Master.supabaseClient.From<Game>().Get()).Models;


            return (await Master.supabaseClient.From<Game>().Filter("user", Constants.Operator.Equals, selector).Get()).Models;
        }

        public static async Task PostNewGame(Game game)
        {
            await Master.supabaseClient.From<Game>().Insert(game);
        }
    }
}
