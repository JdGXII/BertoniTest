using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.Responses;
using Clients;

namespace BertoniAlbumSearcher.Controllers
{
    public class HomeController : Controller
    {
        private readonly AlbumClient _albumClient;

        public HomeController(AlbumClient albumClient)
        {
            _albumClient = albumClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region API Methods

        [HttpGet]
        public async Task<List<AlbumResponse>> GetAlbums()
        {
            return await _albumClient.GetAlbums();
        }

        [HttpGet]
        public async Task<List<PhotoResponse>> GetPhotos(int? albumId)
        {
            return await _albumClient.GetPhotos(albumId);
        }

        #endregion

    }
}
