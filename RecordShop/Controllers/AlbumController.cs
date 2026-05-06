
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components;
using RecordShop.Models;
using RecordShop.Services;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using Microsoft.AspNetCore.Authorization;

namespace RecordShop.Controllers
{
    [ApiController]
    [Route("/albums")]

    public class AlbumController : ControllerBase
    {
        private readonly AlbumService _albumService;
        public AlbumController(AlbumService albumService)
        {
            _albumService = albumService;
        }

        [HttpGet("/albums")]
        public IActionResult GetAllAlbums()
        {
            var albums = _albumService.GetAllAlbums();
            return Ok(albums);
        }
        [HttpGet("/albums/{id}")]
        public IActionResult GetAlbum(int id)
        {
            var albums = _albumService.GetAllAlbums();
            var album = albums.FirstOrDefault(a => a.Id == id);
            if (album == null)
            {
                return NotFound();
            }
            return Ok(album);
        }
        [HttpGet("/albums/title/")]
        public IActionResult GetAlbumByTitle(string title)
        {
            var albums = _albumService.GetAllAlbums();
            var album = albums.FindAll(a => a.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
            if (album == null)
            {
                return NotFound();
            }
            return Ok(album);
        }
        [HttpGet("/albums/artist/")]
        public IActionResult GetAlbumByArtist(string artist)
        {
            var albums = _albumService.GetAllAlbums();
            var album = albums.FindAll(a => a.Artist.Contains(artist, StringComparison.OrdinalIgnoreCase));
            if (album == null)
            {
                return NotFound();
            }
            return Ok(album);
        }
        [Authorize]
        [HttpPost("/albums")]
        public IActionResult AddAlbum([FromBody] Album album)
        {
            var addedAlbum = _albumService.AddAlbum(album);
            return CreatedAtAction(nameof(GetAllAlbums), new { id = addedAlbum.Id }, addedAlbum);
        }
        [Authorize]
        [HttpDelete("/albums/{id}")]
        public IActionResult DeleteAlbum(int id, [FromBody] Album deletedAlbum)
        {
            var album = _albumService.DeleteAlbum(id, deletedAlbum);
            if (album == null)
            {
                return NotFound();
            }
            return Ok(album);
        }
        [Authorize]
        [HttpPut("/albums/{id}")]
        public IActionResult UpdateAlbum(int id, [FromBody] Album updatedAlbum)
        {
            var album = _albumService.UpdateAlbum(id, updatedAlbum);
            if (album == null)
            {
                return NotFound();
            }
            return Ok(album);
        }
    }
}
    