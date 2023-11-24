using Microsoft.EntityFrameworkCore;
using UrlShorterer.Entities;
using UrlShorterer.Models;

namespace UrlShortener.Data
{
    public class UrlShortenerContext : DbContext
    {   
        public UrlShortenerContext(DbContextOptions<UrlShortenerContext> options) : base(options){}
        public DbSet<User> Users { get; set; }
        public DbSet<Url> Urls { get; set; }

    }
}


