using Fantasy_Premier_League_Stats.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Fantasy_Premier_League_Stats.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SpecificPlayer : Page
    {
        public SpecificPlayer()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Player player = e.Parameter as Player;
            Name.Text = player.full_name;
            Team.Text = player.team_name;
            Position.Text = player.position;
            Cost.Text = player.now_cost.ToString();
            CostChanges.Text = player.cost_change_event.ToString();
            TotalPoints.Text = player.total_points.ToString();
            pointsThisWeek.Text = player.event_points.ToString();
            Goals.Text = player.goals_scored.ToString();
            Assists.Text = player.assists.ToString();
            Minutes.Text = player.minutes.ToString();
            cleanSheets.Text = player.clean_sheets.ToString();
            RedCards.Text = player.red_cards.ToString();
            yellowCards.Text = player.yellow_cards.ToString();
            //TransfersIn.Text = player.transfers_in_event.ToString();
            //TransfersOut.Text = player.transfers_out_event.ToString();
            //TransfersDiff.Text = (player.transfers_in_event - player.transfers_out_event).ToString();
            availability.Text = player.injured;


        }
    }
}
