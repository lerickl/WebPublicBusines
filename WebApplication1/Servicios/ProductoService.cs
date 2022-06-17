using WebApplication1.DataDb;
using WebApplication1.Models.viewModels;
using WebApplication1.Servicios.Interfaces;

namespace WebApplication1.Servicios
{
    public class ProductoService : IProductoService
    {
        public readonly WebeOContext _db;
        public ProductoService(WebeOContext db) {
            this._db = db;
        }
        public IList<Producto> search(Search search)
        {
            if (search.categoria != 0 && search.busqueda != null)
            {

                var data = _db.Productos.Where(x => x.CategoriaId == search.categoria).ToList();
                var busq = buscarPalabra(search.busqueda, data);
                return busq;


            }
            if (search.categoria == 0 && search.busqueda != null)
            {
                var data = _db.Productos.ToList();
                var busq = buscarPalabra(search.busqueda, data);
                return busq;
            }
            if (search.categoria != 0 && search.busqueda == null)
            {
                var data = _db.Productos.Where(x => x.CategoriaId == search.categoria).ToList();

                return data;
            }
            return null;
        }
        public static IList<Producto> buscarPalabra(string palabra, IList<Producto> Productos)
        {
            palabra = palabra.ToLowerInvariant();
            var response = new List<Producto>();
            foreach (var prod in Productos)
            {
                if (prod.Nombre.ToLowerInvariant().Contains(palabra))
                {
                    response.Add(prod);
                }
            }
            return response;

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

        public Producto GetProductByIdP(int? Id)
        {
            return _db.Productos.Where(x=>x.ProductoId==Id).FirstOrDefault();
        }

        public IList<Producto> GetProductoByID(int? IdEmpresa)
        {
            return _db.Productos.Where(x => x.EmpresaId == IdEmpresa).ToList();
        }

        public bool DeletProduct(int id, int? EmpresaId)
        {
            var dat = _db.Productos.Where(e => e.ProductoId == id && e.EmpresaId == EmpresaId);
            if (dat != null) 
            {
                _db.Productos.RemoveRange(dat);
                _db.SaveChanges();
                return true;
            }return false;
            
             
        }

        public bool EditProduct(Producto prod)
        {          
            try 
            {
                var product = _db.Productos.Where(e => e.ProductoId == prod.ProductoId).FirstOrDefault();
                product.Nombre = prod.Nombre;
                product.Precio = prod.Precio;
                product.Descripcion = prod.Descripcion;
                product.Marca = prod.Marca;
                product.ImagenP = prod.ImagenP;
                product.CategoriaId = prod.CategoriaId;
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
