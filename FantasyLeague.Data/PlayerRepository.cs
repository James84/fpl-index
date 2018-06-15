using FantasyLeague.Data.Interfaces;
using FantasyLeague.Domain;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FantasyLeague.Data
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient _client;

        public PlayerRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _client = _httpClientFactory.CreateClient("playerClient");
        }

        public async Task<IEnumerable<Player>> GetAll()
        {
            var playerResponse = await _client.GetAsync("https://fantasy.premierleague.com/drf/elements/");

            if (!playerResponse.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Player request failed with status: {playerResponse.StatusCode}");
            }

            var content = await playerResponse.Content.ReadAsStringAsync();

            var players = JsonConvert.DeserializeObject<IEnumerable<Player>>(content);

            return players;
        }
    }
}
