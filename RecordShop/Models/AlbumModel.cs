using System.Text.Json;

namespace RecordShop.Models
{
    public class AlbumModel
    {

        string _filepath = ".\\Repositories\\AlbumData.json";
        public List<Album> GetAllAlbums()
        {
            var jsonData = File.ReadAllText(_filepath);
            var option = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var albums = JsonSerializer.Deserialize<List<Album>>(jsonData, option);
            return albums;
        }
    }
}
