using API.Interfaces;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Services
{
    public class JokeService : IJokeService
    {
        private readonly ILogger _logger;
        private readonly HttpClient _http;
        private readonly IConfiguration _configuration;
        public JokeService(
            ILogger logger,
            HttpClient http,
            IConfiguration configuration
            )
        {
            _logger = logger;
            _http = http;
            _configuration = configuration;
        }
        public async Task<HttpResponseMessage> GetRandomJoke()
        {
            var response = await _http.GetAsync($"{_configuration.GetSection("BaseURI")}random_joke");
            return response;
        }
        public async Task<HttpResponseMessage> GetTenRandomJokes()
        {
            var response = await _http.GetAsync($"{_configuration.GetSection("BaseURI")}random_ten");
            return response;
        }
    }
}
