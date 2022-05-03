using WebApplication1.Models;

namespace WebApplication1.Servicios.Interfaces
{
    public interface IAuthService
    {
        Usuario Login(Usuario usuario);
        void Logout();
        Usuario GetLogedUser();
    }
}
