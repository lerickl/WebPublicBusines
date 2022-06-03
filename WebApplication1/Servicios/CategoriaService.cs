using WebApplication1.DataDb;
using WebApplication1.Servicios.Interfaces;

namespace WebApplication1.Servicios
{
    public class CategoriaService : ICategoriaService
    {
        public readonly WebeOContext _db;
        public CategoriaService(WebeOContext db) {
            this._db = db;
        }
        public void AddUsuario(CategoriaEmpresa categoria)
        {
            throw new NotImplementedException();
        }

        public void EditarCategoria(int idCategoria, CategoriaEmpresa categoria)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> GetAllCategoria()
        {
           return _db.Categoria.ToList();
        }

        public CategoriaEmpresa GetCategoriaByID(int? IdCategoria)
        {
            throw new NotImplementedException();
        }
    }
}
