using API.Models;

namespace API.Interfaces
{
    public interface IJokeService
    {
        Task<Joke> GetRandomJoke();
        Task<List<Joke>> GetTenRandomJokes();
    }
}
