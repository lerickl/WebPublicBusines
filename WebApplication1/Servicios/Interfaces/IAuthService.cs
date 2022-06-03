

using WebApplication1.DataDb;

namespace WebApplication1.Servicios.Interfaces
{
    public interface IAuthService
    {
        string Login(string email, string contraseña);
        void Logout();
        Usuario GetLogedUser();
        Empresa GetLogedEmpr();
    }
}
