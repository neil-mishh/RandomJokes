using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Interfaces
{
    public interface IJokeService
    {
        Task<HttpResponseMessage> GetRandomJoke();
        Task<HttpResponseMessage> GetTenRandomJokes();
    }
}
