using System;
using FantasyLeague.Domain;
using FantasyLeague.ElasticSearch.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FantasyLeague.ElasticSearch.Extensions;
using Nest;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FantasyLeague.Controllers
{
    [ApiController]
    [Route("playersearch")]
    public class PlayerSearchController : ControllerBase
    {
        private readonly ISearchService<Player> _searchService;

        public PlayerSearchController(ISearchService<Player> searchService)
        {
            _searchService = searchService;
        }

        [HttpGet("")]
        // GET: /<controller>/
        public async Task<ActionResult<IEnumerable<Player>>> Players([FromQuery]PlayerSearchCriteria criteria)
        {
            //PlayerSearchCriteria criteria = new PlayerSearchCriteria();

            var players2 = await _searchService
                                 .SearchQuery(criteria);

            return players2?.ToList();
        }


        [HttpGet("all")]
        // GET: /<controller>/
        public async Task<ActionResult<IEnumerable<Player>>> Players()
        {
            //PlayerSearchCriteria criteria = new PlayerSearchCriteria();

            var players2 = await _searchService.Search();

            return players2?.ToList();
        }
    }
}
