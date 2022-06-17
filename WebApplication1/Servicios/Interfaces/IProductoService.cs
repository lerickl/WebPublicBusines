

using WebApplication1.DataDb;
using WebApplication1.Models.viewModels;

namespace WebApplication1.Servicios.Interfaces
{
    public interface IProductoService
    {
        void addProduct(Producto product);
        IList<Producto> GetProductoByID(int? IdEmpresa);
        IEnumerable<Producto> GetAllProducts();
        Producto GetProductByIdP(int? Id);
        public IList<Producto> search(Search search);
        void EditarProducto(int IdProducto);
        public bool DeletProduct(int id, int? EmpresaId);
        public bool EditProduct(Producto prod);
    }
}
