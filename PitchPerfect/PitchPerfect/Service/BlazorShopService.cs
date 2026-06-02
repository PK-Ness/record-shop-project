using Shared.Models;
using System.Net.Http;
using System.Net.Http.Json;
using PitchPerfect.Service;

namespace PitchPerfect.Service
{
    public class BlazorShopService
    {

        private readonly HttpClient _http;

        public BlazorShopService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<AlbumModel>> GetAlbumsAsync()
        {
            return await _http.GetFromJsonAsync<List<AlbumModel>>(
                "https://localhost:5001/api/albums")
                ?? new List<AlbumModel>();
        }
    }
}
