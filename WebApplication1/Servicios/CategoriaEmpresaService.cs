using WebApplication1.DataDb;
using WebApplication1.Servicios.Interfaces;

namespace WebApplication1.Servicios
{
    public class CategoriaEmpresaService : ICategoriaEmpresa
    {
        public readonly WebeOContext _db;
        public CategoriaEmpresaService(WebeOContext db) {
            this._db = db;
        }
       
        IList<CategoriaEmpresa> ICategoriaEmpresa.getCategorias()
        {
            var categoria= _db.CategoriaEmpresa.ToList();
            return categoria;
        }
    }
}
