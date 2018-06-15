using FantasyLeague.Data.Interfaces;
using FantasyLeague.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyLeague.Controllers
{
    [ApiController]
    [Route("teams")]
    public class TeamController : ControllerBase
    {
        private readonly ITeamRepository _teamRepository;

        public TeamController(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Team>>> Index()
        {
            var teams = await _teamRepository.GetAll();

            return teams.ToList();
        }
    }
}