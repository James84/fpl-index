using FantasyLeague.Data.Interfaces;
using FantasyLeague.Domain;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FantasyLeague.Data
{
    public class TeamRepository : ITeamRepository
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient _client;

        public TeamRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _client = httpClientFactory.CreateClient("teamClient");
        }

        public async Task<IEnumerable<Team>> GetAll()
        {
            var teamResponse = await _client.GetAsync("https://fantasy.premierleague.com/drf/teams/");

            if (!teamResponse.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Team request failed with status: {teamResponse.StatusCode}");
            }

            var teamResponseContent = await teamResponse.Content.ReadAsStringAsync();

            var teams = JsonConvert.DeserializeObject<IEnumerable<Team>>(teamResponseContent);

            return teams;
        }
    }
}
