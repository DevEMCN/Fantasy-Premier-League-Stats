using Fantasy_Premier_League_Stats.Data;
using Fantasy_Premier_League_Stats.Models;
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
    public sealed partial class Players : Page
    {
        public Players()
        {
            this.InitializeComponent();
            PlayerModel playerM = new PlayerModel();
            PlayersList = playerM.GetPlayers();
           
        }

        private IList<Player> PlayersList;


        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var playerData = e.AddedItems[0];
            Frame.Navigate(typeof(Views.SpecificPlayer), playerData);
        }

        private void MyAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var filtered = PlayersList.Where(i => i.full_name.Contains(this.MyAutoSuggestBox.Text)).ToList();
            PlayersGrid.ItemsSource = filtered;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var sorted = PlayersList.Where(i => i.second_name.Contains(this.MyAutoSuggestBox.Text)).ToList();
            var sortTerm = MyComboBox.SelectedIndex;
            IList sorted = null;
            switch (sortTerm)
            {
                case 0:
                    sorted = PlayersList.OrderBy(x => x.team_name).ToList();
                    break;
                case 1:
                    sorted = PlayersList.OrderBy(x => x.position).ToList();
                    break;
                case 2:
                    sorted = PlayersList.OrderByDescending(x => x.total_points).ToList();
                    break;
            }
            PlayersGrid.ItemsSource = sorted;
        }
    }
}
