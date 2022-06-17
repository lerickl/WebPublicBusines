using WebApplication1;
using WebApplication1.DataDb;

namespace WebApplication1.Servicios.Interfaces
{
    public interface IUsuarioService
    {
        void AddUsuario(Usuario usuario);
        Usuario GetUsuarioByID(int? IdUsuario);
        IEnumerable<Usuario> GetAllUsers();
        Usuario GetUsuarioByEmailAndPassword(string correo, string clave);
        //void AddUsuario(UsuarioViewModel uservm);
        void EditarUsuario(int? idUser, Usuario user);
    }
}
