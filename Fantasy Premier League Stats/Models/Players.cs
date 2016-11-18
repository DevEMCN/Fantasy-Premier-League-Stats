
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
    public class Players
    {
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

        private static IList<PlayerStats> createStatsList(IList<JToken> results)
        {
            IList<PlayerStats> stats = new List<PlayerStats>();
            foreach (JToken r in results)
            {
                PlayerStats pStats = JsonConvert.DeserializeObject<PlayerStats>(r.ToString());
                stats.Add(pStats);
            }
            return stats;
        }
    }
}
