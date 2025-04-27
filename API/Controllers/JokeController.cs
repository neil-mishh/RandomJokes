using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokeController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly JokeService _jokeService;

        public JokeController(
            ILogger logger,
            JokeService jokeService
            )
        {
            _logger = logger;
            _jokeService = jokeService;

        }

        [HttpGet("random_joke")]
        public async Task<IActionResult> GetRandomJoke()
        {
            var result = await _jokeService.GetRandomJoke();
            return Ok(result);
        }
    }
}
