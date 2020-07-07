using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Models.Responses;
using Clients.Interface;

namespace Clients
{
    public class AlbumClient : IAlbumClient
    {
        private readonly HttpClient _httpClient;

        public AlbumClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<AlbumResponse>> GetAlbums()
        {

            string url = "https://jsonplaceholder.typicode.com/albums";
            var responseString = await _httpClient.GetStringAsync(url);
            var response = JsonConvert.DeserializeObject<List<AlbumResponse>>(responseString);

            return response;
        }

        public async Task<List<PhotoResponse>> GetPhotos(int? albumId)
        {

            string url = $"https://jsonplaceholder.typicode.com/photos?albumId={albumId}";
            var responseString = await _httpClient.GetStringAsync(url);
            var response = JsonConvert.DeserializeObject<List<PhotoResponse>>(responseString);

            return response;
        }
    }
}
