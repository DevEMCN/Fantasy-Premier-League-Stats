using Fantasy_Premier_League_Stats.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Premier_League_Stats.ViewModels
{
    public class PlayerViewModel
    {
        public PlayerViewModel(Player player = null) { }

        public int id { get { return id; } }

        public string photo { get { return photo; } }

        public string web_name { get { return web_name; } }

        public int team_code { get { return team_code; } }

        public string status { get { return status; } }

        public int code { get { return code; } }

        public string first_name { get { return first_name; } }

        public string second_name { get { return second_name; } }

        public int? squad_number { get { return squad_number; } }

        public string news { get { return news; } }

        public int now_cost { get { return now_cost; } }

        public int? chance_of_playing_this_round { get { return chance_of_playing_this_round; } }

        public int? chance_of_playing_next_round { get { return chance_of_playing_next_round; } }

        public string value_form { get { return value_form; } }

        public string value_season { get { return value_season; } }

        public int cost_change_start { get { return cost_change_start; } }

        public int cost_change_event { get { return cost_change_event; } }

        public int cost_change_start_fall { get { return cost_change_start_fall; } }

        public int cost_change_event_fall { get { return cost_change_event_fall; } }

        public bool in_dreamteam { get { return in_dreamteam; } }

        public int dreamteam_count { get { return dreamteam_count; } }

        public string selected_by_percent { get { return selected_by_percent; } }

        public string form { get { return form; } }

        public int transfers_out { get { return transfers_out; } }

        public int transfers_in { get { return transfers_in; } }

        public int transfers_out_event { get { return transfers_out_event ; } }

        public int transfers_in_event { get { return transfers_in_event; } }

        public int loans_in { get { return loans_in; } }

        public int loans_out { get { return loans_out; } }

        public int loaned_in { get { return loaned_in; } }

        public int loaned_out { get { return loaned_out; } }

        public int total_points { get { return total_points; } }

        public int event_points { get { return event_points; } }

        public string points_per_game { get { return points_per_game; } }

        public string ep_this { get { return ep_this; } }

        public string ep_next { get { return ep_next; } }

        public bool special { get { return special; } }

        public int minutes { get { return minutes; } }

        public int goals_scored { get { return goals_scored; } }

        public int assists { get { return assists; } }

        public int clean_sheets { get { return clean_sheets; } }

        public int goals_conceded { get { return goals_conceded; } }

        public int own_goals { get { return own_goals; } }

        public int penalties_saved { get { return penalties_saved; } }

        public int penalties_missed { get { return penalties_missed; } }

        public int yellow_cards { get { return yellow_cards; } }

        public int red_cards { get { return red_cards; } }

        public int saves { get { return saves; } }

        public int bonus { get { return bonus; } }

        public int bps { get { return bps; } }

        public string influence { get { return influence; } }

        public string creativity { get { return creativity; } }

        public string threat { get { return threat; } }

        public string ict_index { get { return ict_index; } }

        public int ea_index { get { return ea_index; } }

        public int element_type { get { return element_type; } }

        public int team { get { return team; } }
    }
}
