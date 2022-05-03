using WebApplication1.Models;

namespace WebApplication1.Servicios.Interfaces
{
    public interface ICategoriaService
    {
        void AddUsuario(Categoria categoria);
        Categoria GetCategoriaByID(int? IdCategoria);

        IEnumerable<Categoria> GetAllCategoria();

        void EditarCategoria(int idCategoria, Categoria categoria);

    }
}
