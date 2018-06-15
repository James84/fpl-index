using FantasyLeague.Data.Interfaces;
using FantasyLeague.Domain;
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

        public PlayerController(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Player>>> Index()
        {
            var players = await _playerRepository.GetAll();

            return players.ToList();
        }
    }
}