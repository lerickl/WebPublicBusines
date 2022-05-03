using WebApplication1.Models;

namespace WebApplication1.Servicios.Interfaces
{
    public interface IServicioService
    {
        void AddServicio(Servicio servicio);
        Servicio GetServicioByID(int? IdServicio);

        IEnumerable<Servicio> GetAllServicio();

        void EditarServicio(int idServicio, Servicio servicio);
    }
}
