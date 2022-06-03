
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
        public void AddServicio(Servicio servicio)
        {
            _db.Servicios.Add(servicio);
            _db.SaveChanges();
        }

        public void EditarServicio(int idServicio, Servicio servicio)
        {
            throw new NotImplementedException();
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
    }
}
