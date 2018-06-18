using FantasyLeague.Data.Interfaces;
using FantasyLeague.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FantasyLeague.ElasticSearch.Interfaces;

namespace FantasyLeague.Controllers
{
    [ApiController]
    [Route("teams")]
    public class TeamController : ControllerBase
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IIndexer _indexer;

        public TeamController(ITeamRepository teamRepository, IIndexer indexer)
        {
            _teamRepository = teamRepository;
            _indexer = indexer;
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Team>>> Get()
        {
            var teams = await _teamRepository.GetAll();

            return teams.ToList();
        }

        [HttpGet("index")]
        public async Task<ActionResult> Index()
        {
            var teams = await _teamRepository.GetAll();

            await _indexer.DeleteIndex("team");
            await _indexer.Index(teams);

            return Ok();
        }
    }
}