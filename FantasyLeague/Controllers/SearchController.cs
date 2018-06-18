using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyLeague.Domain;
using FantasyLeague.ElasticSearch.Interfaces;
using FantasyLeague.Models;
using Microsoft.AspNetCore.Mvc;
using Nest;

namespace FantasyLeague.Controllers
{
    [Route("search")]
    public class SearchController : Controller
    {
        private readonly ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet("players")]
        public async Task<IActionResult> PlayerIndex()
        {
            //var players = await _searchService
            //                   .SearchQuery<Player>(q => 
            //                                            q.Bool(b => 
            //                                                    b.Should(
            //                                                           bs => bs.Term(p => p.Team, "Arsenal"))));

            //var players2 = await _searchService
            //    .SearchQuery<Player>(q =>
            //        q.Bool(b => b
            //            .Should(
            //                bs => bs.Term(p => p.Team, "Arsenal"),
            //                bs => bs.Term(p => p.SecondName, "Lacazette")
            //            )
            //        ));


        var players3 = await _searchService
            .Search<Player>();
            
        var model = new PlayerViewModel(players3);

            return View(model);
        }

        [HttpGet("teams")]
        public async Task<IActionResult> TeamIndex()
        {
            var teams = await _searchService.Search<Team>();

            var model = new TeamViewModel(teams);

            return View(model);
        }
    }
}