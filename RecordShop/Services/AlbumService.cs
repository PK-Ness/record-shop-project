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

        public Album? AddAlbum(Album album)
        {
            var model = _albumModel.GetAllAlbums();
            int nextId = model.Any() ? model.Max(a => a.Id) + 1 : 1;
            album.Id = nextId;
            _albumModel.AddAlbum(album);
            return album;
        }
    }
}
