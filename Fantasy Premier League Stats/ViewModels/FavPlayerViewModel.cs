using Fantasy_Premier_League_Stats.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Premier_League_Stats.ViewModels
{
    public class FavPlayerViewModel
    {
        public static ObservableCollection<Player> FavPlayersList = new ObservableCollection<Player>();

        public FavPlayerViewModel()
        {
 
        }
        
        public void AddPlayer(Player player)
        {
            FavPlayersList.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            FavPlayersList.Remove(player);
        }

        public IList<Player> GetFavPlayers()
        {
            return FavPlayersList;
        }
    }
}
