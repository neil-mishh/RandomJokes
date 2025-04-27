using API.Interfaces;
using API.Models;
using System.Net.Http.Json;

namespace API.Services
{
    public class JokeService : IJokeService
    {
        private readonly ILogger<JokeService> _logger;
        private readonly HttpClient _http;
        public JokeService(ILogger<JokeService> logger, HttpClient http)
        {
            _logger = logger;
            _http = http;
        }
        public async Task<Joke> GetRandomJoke()
        {
            var joke = await _http.GetFromJsonAsync<Joke>("random_joke");
            return joke;
        }
        public async Task<List<Joke>> GetTenRandomJokes()
        {
            var joke = await _http.GetFromJsonAsync<List<Joke>>("random_ten");
            return joke;
        }
    }
}
