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

        [HttpGet("PeliculasByGenero")]
        public List<pelicula> GetPeliculasByGenero(string genero)
        {
            return _administrable.GetPeliculasByGenero(genero);
        }

    }
}
