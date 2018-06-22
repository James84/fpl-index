using System;
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
    public class PlayerIndexerController : ControllerBase
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IIndexer _indexer;

        public PlayerIndexerController(IPlayerRepository playerRepository, IIndexer indexer)
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
            try
            {
                var players = (await _playerRepository.GetAll()).ToList();

                if (!players.Any())
                {
                    return NotFound("No players to index.");
                }

                await _indexer.DeleteIndex("players");
                await _indexer.Index(players);

                return Ok($"{players.Count} players indexed.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error indexing players: {ex}");
            }
        }

        [HttpGet("delete")]
        public async Task<ActionResult> Delete()
        {
            await _indexer.DeleteIndex("players");

            return Ok();
        }
    }
}