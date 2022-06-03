using WebApplication1.DataDb;

namespace WebApplication1.Servicios.Interfaces
{
    public interface ICategoriaEmpresa
    {
        IList<CategoriaEmpresa> getCategorias();
    }
}
