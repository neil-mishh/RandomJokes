using API.Interfaces;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokeController : ControllerBase
    {
        private readonly ILogger<JokeController> _logger;
        private readonly IJokeService _jokeService;

        public JokeController(ILogger<JokeController> logger, IJokeService jokeService)
        {
            _logger = logger;
            _jokeService = jokeService;
        }

        [HttpGet("random_joke")]
        public async Task<Joke> GetRandomJoke()
        {
            var result = await _jokeService.GetRandomJoke();
            return result;
        }

        [HttpGet("random_ten")]
        public async Task<List<Joke>> GetRandomTen()
        {
            var result = await _jokeService.GetTenRandomJokes();
            return result;
        }
    }
}
