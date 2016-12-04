using Fantasy_Premier_League_Stats.Data;
using Fantasy_Premier_League_Stats.Models;
using System;
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

        //private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    var playerData = ((Player)e.ClickedItem).first_name + " " + ((Player)e.ClickedItem).second_name;
        //    Frame.Navigate(typeof(Views.SpecificPlayer), playerData);
        //}

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var playerData = e.AddedItems[0];
            Frame.Navigate(typeof(Views.SpecificPlayer), playerData);
        }
    }
}
