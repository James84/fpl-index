using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FantasyLeague.Domain;
using FantasyLeague.ElasticSearch.Interfaces;
using FantasyLeague.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FantasyLeague.Controllers
{
    [Route("search/teams")]
    [ApiController]
    public class TeamSearchController : ControllerBase
    {
        private readonly ISearchService<Team, TeamSearchCriteria> _searchService;
        private readonly IMapper _mapper;

        public TeamSearchController(ISearchService<Team, TeamSearchCriteria> searchService, IMapper mapper)
        {
            _searchService = searchService;
            _mapper = mapper;
        }
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<TeamModel>>> Index()
        {
            var teams = await _searchService.GetAll(take: 20);

            var mappedTeams = teams.Select(t => _mapper.Map<Team, TeamModel>(t));

            return mappedTeams.OrderBy(t => t.Name).ToList();
        }
    }
}