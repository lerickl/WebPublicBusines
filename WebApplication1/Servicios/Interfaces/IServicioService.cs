
using WebApplication1.DataDb;
using WebApplication1.Models.viewModels;

namespace WebApplication1.Servicios.Interfaces
{
    public interface IServicioService
    {
        void AddServicio(Servicio servicio);
        Servicio GetServicioByID(int? IdServicio);

        IEnumerable<Servicio> GetAllServicio();
        IList<Servicio> GetAllServicioListById(int? id);

        void EditarServicio(int idServicio, Servicio servicio);
    }
}
