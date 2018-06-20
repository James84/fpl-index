using System;
using FantasyLeague.Domain;
using FantasyLeague.ElasticSearch.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FantasyLeague.ElasticSearch.Extensions;
using FantasyLeague.Models;
using Nest;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FantasyLeague.Controllers
{
    [ApiController]
    [Route("playersearch")]
    public class PlayerSearchController : ControllerBase
    {
        private readonly ISearchService<Player> _searchService;
        private readonly IMapper _mapper;

        public PlayerSearchController(ISearchService<Player> searchService, IMapper mapper)
        {
            _searchService = searchService;
            _mapper = mapper;
        }

        [HttpGet("")]
        // GET: /<controller>/
        public async Task<ActionResult<IEnumerable<PlayerModel>>> Players([FromQuery]PlayerSearchCriteria criteria)
        {
            //PlayerSearchCriteria criteria = new PlayerSearchCriteria();

            var players = await _searchService
                                 .SearchQuery(criteria);

            var mappedPlayers = players.Select(p => _mapper.Map<PlayerModel>(p));

            return mappedPlayers.ToList();
        }


        [HttpGet("all")]
        // GET: /<controller>/
        public async Task<ActionResult<IEnumerable<PlayerModel>>> Players()
        {
            //PlayerSearchCriteria criteria = new PlayerSearchCriteria();

            var players = await _searchService.Search();

            var mappedPlayers = players.Select(p => _mapper.Map<PlayerModel>(p));

            return mappedPlayers.ToList();
        }
    }
}
