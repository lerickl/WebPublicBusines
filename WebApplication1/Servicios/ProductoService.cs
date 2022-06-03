using WebApplication1.DataDb;

using WebApplication1.Servicios.Interfaces;

namespace WebApplication1.Servicios
{
    public class ProductoService : IProductoService
    {
        public readonly WebeOContext _db;
        public ProductoService(WebeOContext db) {
            this._db = db;
        }
        public void addProduct(Producto product)
        {
            _db.Productos.Add(product);
            _db.SaveChanges();
        }

        public void EditarProducto(int IdProducto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> GetAllProducts()
        {
            return _db.Productos.ToList();
        }

        public Producto GetProductById(int? Id)
        {
            return _db.Productos.Where(x=>x.ProductoId==Id).FirstOrDefault();
        }

        public IList<Producto> GetProductoByID(int? IdEmpresa)
        {
            return _db.Productos.Where(x => x.EmpresaId == IdEmpresa).ToList();
        }
    }
}
