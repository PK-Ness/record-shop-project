
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Components;
using RecordShop.Models;
using RecordShop.Services;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

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

        [HttpPost("/albums")]
        public IActionResult AddAlbum([FromBody] Album album)
        {
            var addedAlbum = _albumService.AddAlbum(album);
            return CreatedAtAction(nameof(GetAllAlbums), new { id = addedAlbum.Id }, addedAlbum);
        }
    }
}
    