using AdministrarPeliculas_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AdministrarPeliculas_API.ContextDB
{
    public class peliculaContext : DbContext
    {
        public peliculaContext (DbContextOptions<peliculaContext> db ) : base(db) { }

        public DbSet<pelicula> pelicula { get; set; }
    }
}
