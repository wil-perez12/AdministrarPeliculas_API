using AdministrarPeliculas_API.Intefaces;
using AdministrarPeliculas_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdministrarPeliculas_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class peliculaController : ControllerBase
    {
        private readonly IAdministrable _administrable;

        public peliculaController(IAdministrable _administrable)
        {
            this._administrable = _administrable;
        }

        [HttpGet("lista-Peliculas")]
        public List<pelicula> GetPeliculas()
        {
            return _administrable.GetPeliculas();
        }

        [HttpGet("PeliculasByGenero{genero}")]
        public List<pelicula> GetPeliculasByGenero(string genero)
        {
            return _administrable.GetPeliculasByGenero(genero);
        }

        [HttpPost("post-Peli")]
        public string postPelicula([FromBody] pelicula pelicula)
        {
            return _administrable.postPelicula(pelicula);
        }

        [HttpDelete("Delete-Peli/{id}")]
        public string deletePelicula([FromRoute] int id)
        {
            return _administrable.deletePelicula(id);
        }

        [HttpPut("put/pelicula")]
        public string putPelicula(pelicula pelicula)
        {
            return _administrable.putPelicula(pelicula);
        }
    }
}
