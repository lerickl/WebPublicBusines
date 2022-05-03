using WebApplication1.Models;

namespace WebApplication1.Servicios.Interfaces
{
    public interface IPuntuacionService
    {
        void AddPuntuacion(Puntuacion puntuacion);
        Puntuacion GetPuntuacionByID(int? IdPuntuacion);

        IEnumerable<Puntuacion> GetAllPuntuacion();

        void EditarPuntuacion(int idUser, Puntuacion puntuacion);
    }
}
