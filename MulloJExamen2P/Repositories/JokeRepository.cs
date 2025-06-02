using System.Net.Http.Json;
using MulloJExamen2P.Models;

namespace MulloJExamen2P.Repositories
{
    public class JokeRepository
    {
        private readonly HttpClient _httpClient = new();

        public async Task<Joke> GetRandomJokeAsync()
        {
            var url = "https://official-joke-api.appspot.com/random_joke";
            return await _httpClient.GetFromJsonAsync<Joke>(url);
        }
    }
}
