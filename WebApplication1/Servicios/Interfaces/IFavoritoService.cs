using WebApplication1.Models;

namespace WebApplication1.Servicios.Interfaces
{
    public interface IFavoritoService
    {
        void AddFavorito(Favorito favorito);
        Usuario GetFavoritoByID(int? IdFavorito);

        IEnumerable<Favorito> GetAllFavorito();

        void EditarFavorito(int idFavorito, Favorito favorito);
    }
}
