using AdministrarPeliculas_API.ContextDB;
using AdministrarPeliculas_API.Intefaces;
using AdministrarPeliculas_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdministrarPeliculas_API.Services
{
    public class peliculaService : IAdministrable
    {
        private readonly peliculaContext _context;

        public peliculaService(peliculaContext _context)
        { 
            this._context = _context;
        }

        public string deletePelicula(int id)
        {
            var peliculaRgistrada = _context.pelicula.Find(id);
            _context.pelicula.Remove(peliculaRgistrada);
            _context.SaveChanges();

            return "Usuario Eliminado Correctamente";
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

        public string postPelicula(pelicula pelicula)
        {

            _context.pelicula.Add(pelicula);
            _context.SaveChanges();

            return "Pelicula Agregada correctamenta";

        }

        public string putPelicula(pelicula pelicula)
        {
            
            _context.Entry(pelicula).State = EntityState.Modified;
            _context.SaveChanges();

            return "Pelicula Modificda correctamenta";
        }
    }
}
