using API.DTOs;
using API.Interfaces;
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
        public async Task<JokeDTO> GetRandomJoke()
        {
            var result = await _jokeService.GetRandomJoke();
            var jokeDTO = new JokeDTO
            {
                Setup = result.Setup,
                Punchline = result.Punchline
            };
            return jokeDTO;
        }

        [HttpGet("random_ten")]
        public async Task<List<JokeDTO>> GetRandomTen()
        {
            var result = await _jokeService.GetTenRandomJokes();
            var jokeDTOs = result.Select(joke => new JokeDTO
            {
                Setup = joke.Setup,
                Punchline = joke.Punchline
            }).ToList();
            return jokeDTOs;
        }
    }
}
