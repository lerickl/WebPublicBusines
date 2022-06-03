using WebApplication1.DataDb;

namespace WebApplication1.Servicios.Interfaces
{
    public interface ISessionService
    {
        void GuardarSessionUsr(Usuario usuario, IHttpContextAccessor _context);

        void GuardarSessionEmpr(Empresa empr, IHttpContextAccessor _context);
        void LimpiarSession();
        bool IsLogged();
        bool EsEmpresa();
        bool EsUsuario();
        bool EsSuSession(int? IdUsuario);
        int ConvertirSessionIdAIntId();
        
    }
}
