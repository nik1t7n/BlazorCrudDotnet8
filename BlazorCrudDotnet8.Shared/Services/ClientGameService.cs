using BlazorCrudDotnet8.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrudDotnet8.Shared.Services
{
    public class ClientGameService : IGameService
    {
        // this field wiil be used to send requests to the server
        private readonly HttpClient _httpClient;

        public ClientGameService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // async POST-request
        public async Task<Game> AddGame(Game game)
        {
            // here we send post request with "game" json-serialized data to the "/api/game" address
            var result = await _httpClient
                .PostAsJsonAsync("/api/game", game);
            // returns data in from of "Game" object from json
            return await result.Content.ReadFromJsonAsync<Game>();
        }

        // async DELETE request
        public async Task<bool> DeleteGame(int id)
        {
            // the same logic here and further
            var result = await _httpClient.DeleteAsync($"/api/game/{id}");
            return await result.Content.ReadFromJsonAsync<bool>();
        }

        // async PUT request
        public async Task<Game> EditGame(int id, Game game)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/game/{id}", game);
            return await result.Content.ReadFromJsonAsync<Game>();
        }
        
        public Task<List<Game>> GetAllGames()
        {
            throw new NotImplementedException();
        }

        // async GET request
        public async Task<Game> GetGameById(int id)
        {
            var result = await _httpClient
                .GetFromJsonAsync<Game>($"/api/game/{id}");
            return result;
        }

    }
}
