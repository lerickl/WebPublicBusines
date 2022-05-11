using WebApplication1.DataDb;
using WebApplication1.Servicios.Interfaces;
using System.Web;

namespace WebApplication1.Servicios
{
    public class SessionService : ISessionService
    {
        private readonly HttpContext context;
        private readonly UsuarioService UserServ;
        public SessionService()
        {
             
            WebeOContext conexion = new WebeOContext();
            UserServ = new UsuarioService(conexion);
        }
        public void GuardarSession(Usuario usuario)
        {
            throw new NotImplementedException();
        }
        public int ConvertirSessionIdAIntId()
        {
            throw new NotImplementedException(); ;
        }

        public bool EsEmpresa()
        {
            throw new NotImplementedException();
        }

        public bool EsSuSession(int? IdUsuario)
        {
            throw new NotImplementedException();
        }

        public bool EsUsuario()
        {
            throw new NotImplementedException();
        }

       

        public bool IsLogged()
        {
            throw new NotImplementedException();
        }

        public void LimpiarSession()
        {
            throw new NotImplementedException();
        }
    }
}
