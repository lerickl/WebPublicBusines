using WebApplication1.DataDb;

namespace WebApplication1.Servicios.Interfaces
{
    public interface ICategoriaService
    {
        void AddUsuario(CategoriaEmpresa categoria);
        CategoriaEmpresa GetCategoriaByID(int? IdCategoria);

        IEnumerable<Categoria> GetAllCategoria();

        void EditarCategoria(int idCategoria, CategoriaEmpresa categoria);

    }
}
