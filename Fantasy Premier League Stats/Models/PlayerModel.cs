
using Fantasy_Premier_League_Stats.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Premier_League_Stats.Models
{
    public class PlayerModel
    {
        public IList<Player> Players { get; set; }
        public static IList<Player> players = new List<Player>();

        public PlayerModel()
        {
            Players = players;
        }
        public static async Task LoadData()
        {
            await LoadLocalData();
        }
        public static async Task LoadLocalData()
        {
            // adapted from http://www.newtonsoft.com/json/help/html/SerializingJSONFragments.htm
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://jokecamp.github.io/epl-fantasy-geek/js/static-data.json");
            var result = await response.Content.ReadAsStringAsync();
            JObject data = JObject.Parse(result);
            // get json results objects into a list
            IList<JToken> results = data["elements"].Children().ToList();
            // serialize json results into .net objects

            createStatsList(results);
        }

        private static void createStatsList(IList<JToken> results)
        {
            foreach (JToken r in results)
            {
                Player pStats = JsonConvert.DeserializeObject<Player>(r.ToString());
                players.Add(pStats);
            }
        }
    }
}
