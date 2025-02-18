using AdministrarPeliculas_API.ContextDB;
using AdministrarPeliculas_API.Intefaces;
using AdministrarPeliculas_API.Models;

namespace AdministrarPeliculas_API.Services
{
    public class peliculaService : IAdministrable
    {
        private readonly peliculaContext _context;

        public peliculaService(peliculaContext _context)
        { 
            this._context = _context;
        }

        public List<pelicula> GetPeliculas()
        {
            return _context.pelicula.ToList();
        }

        public List<pelicula> GetPeliculasByGenero(string genero)
        {
            var lista = _context.pelicula.ToList();
            var listaPelis = from p in lista
                             where p.genero == genero
                             select p;

            return listaPelis.ToList();
        }
    }
}
