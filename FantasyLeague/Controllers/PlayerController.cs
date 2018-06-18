using FantasyLeague.Data.Interfaces;
using FantasyLeague.Domain;
using FantasyLeague.ElasticSearch.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyLeague.Controllers
{
    [ApiController]
    [Route("players")]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IIndexer _indexer;

        public PlayerController(IPlayerRepository playerRepository, IIndexer indexer)
        {
            _playerRepository = playerRepository;
            _indexer = indexer;
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Player>>> Get()
        {
            var players = await _playerRepository.GetAll();

            return players.ToList();
        }

        [HttpGet("index")]
        public async Task<ActionResult> Index()
        {
            var players = await _playerRepository.GetAll();

            await _indexer.DeleteIndex("player");
            await _indexer.Index(players);

            return Ok();
        }
    }
}