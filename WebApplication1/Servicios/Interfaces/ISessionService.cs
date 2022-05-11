using WebApplication1.DataDb;

namespace WebApplication1.Servicios.Interfaces
{
    public interface ISessionService
    {
        void GuardarSession(Usuario usuario);
        void LimpiarSession();
        bool IsLogged();
        bool EsEmpresa();
        bool EsUsuario();
        bool EsSuSession(int? IdUsuario);
        int ConvertirSessionIdAIntId();
        
    }
}
