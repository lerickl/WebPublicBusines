using WebApplication1.DataDb;
using System.Web;
using WebApplication1.Servicios.Interfaces;
using Microsoft.AspNetCore.Authentication;

namespace WebApplication1.Servicios
{
    public class AuthService : IAuthService
    {
        private readonly WebeOContext db;
        private readonly IHttpContextAccessor _context;
        private readonly ISessionService _SessionService;
        public AuthService(WebeOContext _db, ISessionService SessionService, IHttpContextAccessor context)
        {
            this.db = _db;
            _SessionService = SessionService;
            _context = context;
            
          
        }

        public Usuario GetLogedUser()
        {
            int dat = Convert.ToInt32(_context.HttpContext.Session.GetString("usuario"));
            Usuario usr = db.Usuarios.Where(x => x.UsuarioId == dat).FirstOrDefault();
            return (usr);
        }
        public Empresa GetLogedEmpr()
        {
            int dat=Convert.ToInt32(_context.HttpContext.Session.GetString("usuario") );
            Empresa empr =db.Empresas.Where(x=>x.EmpresaId == dat).FirstOrDefault();
            return (empr);
        }

        public string Login(string email, string contraseña)
        {
            Usuario user = db.Usuarios.Where(x => x.Email == email && x.Contraseña == contraseña).FirstOrDefault();
            Empresa empr= db.Empresas.Where(x => x.Email == email && x.Contraseña == contraseña).FirstOrDefault();

            if (user != null)
            {
                _SessionService.GuardarSessionUsr(user, _context);

                return "usuario";
                
            }
            else if (empr != null)
            {
                _SessionService.GuardarSessionEmpr(empr,_context);
                return "empresa";
            }
            return null;
            
        }

   

        public void Logout()
        {
            _context.HttpContext.SignOutAsync();
        }

 
    }
}
