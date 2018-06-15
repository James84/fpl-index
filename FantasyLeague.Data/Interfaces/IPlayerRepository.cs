using FantasyLeague.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasyLeague.Data.Interfaces
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Player>> GetAll();
    }
}
