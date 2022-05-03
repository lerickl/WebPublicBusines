using WebApplication1.Models;

namespace WebApplication1.Servicios.Interfaces
{
    public interface IProductoService
    {
        void addProduct(Producto product);
        Producto GetProductoByID(int? IdProducto);
        IEnumerable<Producto> GetAllProducts();

        void EditarProducto(int IdProducto);
    }
}
