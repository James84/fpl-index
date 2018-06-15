using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FantasyLeague.Domain;

namespace FantasyLeague.Data.Interfaces
{
    public interface ITeamRepository
    {
        Task<IEnumerable<Team>> GetAll();
    }
}
