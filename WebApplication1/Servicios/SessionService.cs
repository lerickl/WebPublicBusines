using WebApplication1.DataDb;
using WebApplication1.Servicios.Interfaces;
using System.Web;
using Newtonsoft.Json;

namespace WebApplication1.Servicios
{
    public class SessionService : ISessionService
    {
        private readonly IHttpContextAccessor _context;
        //private readonly UsuarioService UserServ;
        //private readonly WebeOContext _dbContext;
        public SessionService()
        {
            //this._dbContext = dbContext;
            //this._context = IHttpContextAccessor.HttpContext.c;
            //WebeOContext conexion = new WebeOContext();
            //UserServ = new UsuarioService(conexion);
        }
        public void GuardarSessionUsr(Usuario usuario, IHttpContextAccessor _context)
        {
            if (usuario != null) {
                _context.HttpContext.Session.SetString("usuario", Convert.ToString(usuario.UsuarioId));
                _context.HttpContext.Session.SetString("Nombre", usuario.Nombres);
                _context.HttpContext.Session.SetString("TipoUsuario", "User");
            }
           
        }
        public void GuardarSessionEmpr(Empresa empr, IHttpContextAccessor _context)
        {
            _context.HttpContext.Session.SetString("usuario", Convert.ToString(empr.EmpresaId));
            _context.HttpContext.Session.SetString("Nombre", empr.NombreComercial);
            _context.HttpContext.Session.SetString("TipoUsuario", "Empr");
        }
        public bool IsLogged()
        {
            if (_context.HttpContext.Session.GetString("usuario") != null && _context.HttpContext.Session.GetString("TipoUsuario") != null)
                return true;
            return false;
        }
        public bool EsEmpresa()
        {
            if (IsLogged())
            {
                string tipUsr = _context.HttpContext.Session.GetString("TipoUsuario");
                if (tipUsr == "Empr")
                    return true;
            }return false;
        }
        public bool EsUsuario()
        {
            if (IsLogged())
            {
                string tipUsr = _context.HttpContext.Session.GetString("TipoUsuario");
                if (tipUsr == "User")
                    return true;
            }
            return false;
        }
        public int ConvertirSessionIdAIntId()
        {

            throw new NotImplementedException(); ;
        }
         
        public bool EsSuSession(int? IdUsuario)
        {
            if (IsLogged())
            {
                int usrId = Convert.ToInt32(_context.HttpContext.Session.GetString("usuario"));
                if (usrId != IdUsuario)
                    return false;
            
            }
            return true;
        }

        

       

       

        public void LimpiarSession()
        {
            throw new NotImplementedException();
        }
    }
}
