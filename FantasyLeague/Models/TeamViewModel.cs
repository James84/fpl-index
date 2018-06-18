using FantasyLeague.Domain;
using System.Collections.Generic;

namespace FantasyLeague.Models
{
    public class TeamViewModel
    {
        public TeamViewModel(IEnumerable<Team> teams)
        {
            Teams = teams;
        }

        public IEnumerable<Team> Teams { get; set; }
    }
}
