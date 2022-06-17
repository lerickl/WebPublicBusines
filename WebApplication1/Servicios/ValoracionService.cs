using WebApplication1.DataDb;
using WebApplication1.Servicios.Interfaces;

namespace WebApplication1.Servicios
{
    public class ValoracionService : IValoracionService
    {   
        private readonly WebeOContext _db;
        public ValoracionService(WebeOContext db) {
            this._db = db;  
        }
        public Producto AddValoracionProduct(int valoracion, int id)
        {
            var product = _db.Productos.Where(x => x.ProductoId == id).FirstOrDefault();
            return product;
        }

        public void AddValoracionServicio(int valoracion, int id)
        {
            throw new NotImplementedException();
        }
    }
}
