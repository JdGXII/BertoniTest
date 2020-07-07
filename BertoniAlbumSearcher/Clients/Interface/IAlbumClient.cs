using Models.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clients.Interface
{
    public interface IAlbumClient
    {
        Task<List<AlbumResponse>> GetAlbums();
        Task<List<PhotoResponse>> GetPhotos(int? albumId);
    }
}
