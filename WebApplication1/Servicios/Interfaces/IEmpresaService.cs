using WebApplication1.DataDb;

namespace WebApplication1.Servicios.Interfaces
{
    public interface IEmpresaService
    {
        void addEmpresa(Empresa empresa);
        Empresa GetEmpresaByID(int? IdEmpresa);

        IEnumerable<Empresa> GetEmpresas();

        Empresa GetEmpresaByEmailAndPassword(string correo, string clave);
        //void AddUsuario(UsuarioViewModel uservm);

        void EditarEmpresa(int? idUser, Empresa Emprs);
       

    }
}
