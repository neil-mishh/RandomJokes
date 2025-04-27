using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Interfaces
{
    public interface IJokeService
    {
        Task<Joke> GetRandomJoke();
        Task<List<Joke>> GetTenRandomJokes();
    }
}
