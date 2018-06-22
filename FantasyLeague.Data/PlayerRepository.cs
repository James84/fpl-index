using FantasyLeague.Data.Interfaces;
using FantasyLeague.Domain;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

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
            var playerResponse = await _client.GetAsync("/drf/elements/");

            if (!playerResponse.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Player request failed with status: {playerResponse.StatusCode}");
            }

            var players = (await DeserializeResponse<IEnumerable<Player>>(playerResponse)).ToList();

            foreach (var player in players)
            {
                var playerSummary = await EnrichPlayerData(player.Id);

                player.Summary = playerSummary;
            }

            return players;
        }

        private async Task<PlayerSummary> EnrichPlayerData(int playerId)
        {
            var playerResponse = await _client.GetAsync($"drf/element-summary/{playerId}");

            if (!playerResponse.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Player summary request failed with status: {playerResponse.StatusCode}");
            }

            var playerSummary = await DeserializeResponse<PlayerSummary>(playerResponse);

            return playerSummary;
        }

        private static async Task<T> DeserializeResponse<T>(HttpResponseMessage playerResponse)
        {
            var content = await playerResponse.Content.ReadAsStringAsync();

            var players = JsonConvert.DeserializeObject<T>(content);

            return players;
        }
    }
}
