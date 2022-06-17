using WebApplication1.DataDb;

namespace WebApplication1.Servicios.Interfaces
{
    public interface IValoracionService
    {
        Producto AddValoracionProduct(int valoracion, int id);
        void AddValoracionServicio(int valoracion, int id);
    }
}