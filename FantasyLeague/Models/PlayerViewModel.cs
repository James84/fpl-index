using FantasyLeague.Domain;
using System.Collections.Generic;

namespace FantasyLeague.Models
{
    public class PlayerViewModel
    {
        public PlayerViewModel(IEnumerable<Player> players)
        {
            Players = players;
        }

        public IEnumerable<Player> Players { get; set; }
    }
}
