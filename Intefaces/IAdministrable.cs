using AdministrarPeliculas_API.Models;

namespace AdministrarPeliculas_API.Intefaces
{
    public interface IAdministrable
    {

        List<pelicula> GetPeliculas();
        List<pelicula> GetPeliculasByGenero(string genero);

        string postPelicula(pelicula pelicula);
        string putPelicula(pelicula pelicula);
        string deletePelicula(int id);
    }
}
