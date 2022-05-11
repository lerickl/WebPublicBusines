using WebApplication1.DataDb;
using System.Web;
using WebApplication1.Servicios.Interfaces;

namespace WebApplication1.Servicios
{
    public class AuthService : IAuthService
    {
        private readonly WebeOContext db;
        public AuthService(WebeOContext _db)
        {
            db = _db;
        }

        public void GetLogedUser()
        {
            throw new NotImplementedException();
        }

        public Usuario Login(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Models.Usuario Login(Models.Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        Models.Usuario IAuthService.GetLogedUser()
        {
            throw new NotImplementedException();
        }
    }
}
