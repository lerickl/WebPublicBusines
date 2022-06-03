

using WebApplication1.DataDb;

namespace WebApplication1.Servicios.Interfaces
{
    public interface IProductoService
    {
        void addProduct(Producto product);
        IList<Producto> GetProductoByID(int? IdEmpresa);
        IEnumerable<Producto> GetAllProducts();
        Producto GetProductById(int? Id);

        void EditarProducto(int IdProducto);
    }
}
