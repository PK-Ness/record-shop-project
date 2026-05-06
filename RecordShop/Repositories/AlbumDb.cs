using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using RecordShop.Models;
namespace RecordShop.Repositories
{
    public class AlbumDb : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public AlbumDb(DbContextOptions<AlbumDb> options) : base(options)
        {
        }
    }
}
