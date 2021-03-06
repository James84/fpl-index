﻿using AutoMapper;
using FantasyLeague.Domain;
using FantasyLeague.ElasticSearch.Interfaces;
using FantasyLeague.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FantasyLeague.Controllers
{
    [ApiController]
    [Route("search/players")]
    public class PlayerSearchController : ControllerBase
    {
        private readonly ISearchService<Player, PlayerSearchCriteria> _searchService;
        private readonly IMapper _mapper;

        public PlayerSearchController(ISearchService<Player, PlayerSearchCriteria> searchService, IMapper mapper)
        {
            _searchService = searchService;
            _mapper = mapper;
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<PlayerModel>>> GetAll(int skip, int take)
        {
            var players = await _searchService.GetAll(skip, take);

            var mappedPlayers = players.Select(p => _mapper.Map<Player, PlayerModel>(p));

            return mappedPlayers.ToList();
        }

        [HttpGet("prefix")]
        // GET: /<controller>/
        public async Task<ActionResult<IEnumerable<PlayerModel>>> PlayerPrefixSearch([FromQuery]PlayerSearchCriteria criteria)
        {
            var players = await _searchService
                                 .PrefixSearchQuery(criteria);

            var mappedPlayers = players.Select(p => _mapper.Map<Player, PlayerModel>(p));

            return mappedPlayers.ToList();
        }

        [HttpGet("")]
        // GET: /<controller>/
        public async Task<ActionResult<IEnumerable<PlayerModel>>> PlayerSearch([FromQuery]PlayerSearchCriteria criteria)
        {
            var players = await _searchService
                                .SearchQuery(criteria);

            var mappedPlayers = players.Select(p => _mapper.Map<PlayerModel>(p));

            return mappedPlayers.ToList();
        }

        [HttpGet("id/{id:int}")]
        public async Task<ActionResult<PlayerModel>> GetById(int id)
        {
            var player = await _searchService.SearchById(id);

            return _mapper.Map<PlayerModel>(player);
        }
    }
}
