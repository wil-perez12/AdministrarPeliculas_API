using AdministrarPeliculas_API.Models;

namespace AdministrarPeliculas_API.Intefaces
{
    public interface IAdministrable
    {

        List<pelicula> GetPeliculas();
        List<pelicula> GetPeliculasByGenero(string genero);
    }
}
