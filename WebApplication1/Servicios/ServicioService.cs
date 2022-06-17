
using WebApplication1.DataDb;
using WebApplication1.Models.viewModels;
using WebApplication1.Servicios.Interfaces;

namespace WebApplication1.Servicios
{
    public class ServicioService : IServicioService
    {
        public readonly WebeOContext _db;
        public ServicioService(WebeOContext db)
        {
            this._db = db;
        }
        public IList<Servicio> search(Search search)
        {
            if (search.categoria != 0 && search.busqueda != null)
            {
   
                var data = _db.Servicios.Where(x => x.CategoriaId == search.categoria).ToList();
                var busq = buscarPalabra(search.busqueda, data);
                return busq;
            
            
            }
            if (search.categoria == 0&&search.busqueda!=null)
            {
                var data = _db.Servicios.ToList();
                var busq = buscarPalabra(search.busqueda, data);
                return busq; 
            }
            if (search.categoria != 0 && search.busqueda == null)
            {
                var data = _db.Servicios.Where(x => x.CategoriaId == search.categoria).ToList();
         
                return data;
            }
            return null;
        }
        public void AddServicio(Servicio servicio)
        {
            _db.Servicios.Add(servicio);
            _db.SaveChanges();
        }
        public void EditarServicio(Servicio servicio)
        {
            _db.Servicios.Update(servicio);
            _db.SaveChanges();
        }
        public IEnumerable<Servicio> GetAllServicio()
        {
            return _db.Servicios.ToList();
        }
        public IList<Servicio> GetAllServicioListById(int? id)
        {
            return _db.Servicios.Where(x => x.EmpresaId == id).ToList();
         
        }

        public Servicio GetServicioByID(int? IdServicio)
        {
            return _db.Servicios.Where(z=>z.ServicioId==IdServicio).FirstOrDefault();
        }
        public static IList<Servicio> buscarPalabra(string palabra, IList<Servicio> servicios) 
        {
            palabra = palabra.ToLowerInvariant();
            var response = new List<Servicio>();
            foreach (var serv in servicios)
            {
                if (serv.Nombre.ToLowerInvariant().Contains(palabra))
                {
                    response.Add(serv);
                }
            }
            return response;

        }

        public bool DeletServicio(int id, int? idEmpresa)
        {
            var dat=_db.Servicios.Where(x => x.ServicioId == id && x.EmpresaId==idEmpresa).FirstOrDefault();
            if (dat != null) {
                _db.Servicios.Remove(dat);
                _db.SaveChanges();
                return true;
            }return false;
        }
    }
}
