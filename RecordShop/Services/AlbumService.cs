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

        public Album? UpdateAlbum(int id, Album updatedAlbum)
        {
            var model = _albumModel.GetAllAlbums();
            var album = model.FirstOrDefault(a => a.Id == id);
            if (album == null)
            {
                return null;
            }
            updatedAlbum.Id = id;
            _albumModel.UpdateAlbum(id, updatedAlbum);
            return updatedAlbum;
        }

        public Album? DeleteAlbum(int id, Album deletedAlbum)
        {
            var model = _albumModel.GetAllAlbums();
            var album = model.FirstOrDefault(a => a.Id == id);
            if (album == null)
            {
                return null;
            }
            _albumModel.DeleteAlbum(id, deletedAlbum);
            return deletedAlbum;
        }
    }
}
