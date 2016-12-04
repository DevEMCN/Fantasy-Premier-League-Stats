
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
            Players = enhancePlayersList(players);
        }

        public IList<Player> GetPlayers()
        {
            return players;
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

        public static void createStatsList(IList<JToken> results)
        {
            foreach (JToken r in results)
            {
                Player pStats = JsonConvert.DeserializeObject<Player>(r.ToString());
                players.Add(pStats);
            }

        }

        private IList<Player> enhancePlayersList(IList<Player> players)
        {
            foreach (Player player in players)
            {
                switch (player.team)
                {
                    case 1:
                        player.team_name = "Arsenal";
                        player.team_name_short = "ARS";
                        break;
                    case 2:
                        player.team_name = "Bournemouth";
                        player.team_name_short = "BOU";
                        break;
                    case 3:
                        player.team_name = "Burnley";
                        player.team_name_short = "BUR";
                        break;
                    case 4:
                        player.team_name = "Chelsea";
                        player.team_name_short = "CHE";
                        break;
                    case 5:
                        player.team_name = "Crystal Palace";
                        player.team_name_short = "CRY";
                        break;
                    case 6:
                        player.team_name = "Everton";
                        player.team_name_short = "EVE";
                        break;
                    case 7:
                        player.team_name = "Hull City";
                        player.team_name_short = "HUL";
                        break;
                    case 8:
                        player.team_name = "Leicester City";
                        player.team_name_short = "LEI";
                        break;
                    case 9:
                        player.team_name = "Liverpool";
                        player.team_name_short = "LIV";
                        break;
                    case 10:
                        player.team_name = "Manchester City";
                        player.team_name_short = "MCI";
                        break;
                    case 11:
                        player.team_name = "Manchester United";
                        player.team_name_short = "MUN";
                        break;
                    case 12:
                        player.team_name = "Middlesbrough";
                        player.team_name_short = "MID";
                        break;
                    case 13:
                        player.team_name = "Southampton";
                        player.team_name_short = "SOU";
                        break;
                    case 14:
                        player.team_name = "Stoke City";
                        player.team_name_short = "STK";
                        break;
                    case 15:
                        player.team_name = "Sunderland";
                        player.team_name_short = "SUN";
                        break;
                    case 16:
                        player.team_name = "Swansea City";
                        player.team_name_short = "SWA";
                        break;
                    case 17:
                        player.team_name = "Tottenham Hotspur";
                        player.team_name_short = "TOT";
                        break;
                    case 18:
                        player.team_name = "Watford";
                        player.team_name_short = "WAT";
                        break;
                    case 19:
                        player.team_name = "West Bromwich Albion";
                        player.team_name_short = "WBA";
                        break;
                    case 20:
                        player.team_name = "West Ham United";
                        player.team_name_short = "WHU";
                        break;
                }
            }

            foreach(Player player in players)
            {
                player.full_name = player.first_name + " " + player.second_name;
            }

            foreach(Player player in players)
            {
                switch (player.element_type)
                {
                    case 1:
                        player.position = "K";
                        break;
                    case 2:
                        player.position = "DF";
                        break;
                    case 3:
                        player.position = "MF";
                        break;
                    case 4:
                        player.position = "ST";
                        break;
                }
            }

            foreach(Player player in players)
            {
                switch (player.status)
                {
                    case "i":
                        player.injured = "Injured";
                        break;
                    case "a":
                        player.injured = "Available";
                        break;
                }
            }
            return null;
        }
    }
}
