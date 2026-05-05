using RecordShop.Models;

namespace RecordShop.Services
{
    public class AlbumService
    {
        private readonly AlbumModel _albumModel;
        public AlbumService(AlbumModel albumModel)
        {
            _albumModel = albumModel;
        }

        public List<Album> GetAllAlbums()
        {
            return _albumModel.GetAllAlbums();
        }
    }
}
