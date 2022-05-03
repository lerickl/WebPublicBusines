using WebApplication1.DataDb;
using WebApplication1.Servicios.Interfaces;

namespace WebApplication1.Servicios
{
    public class UsuarioService : IUsuarioService
    {
        private readonly WebeOContext _db;
        public UsuarioService(WebeOContext db) 
        {
            this._db = db;
        }

        public void AddUsuario(Usuario usuario)
        {
          
            _db.Usuarios.Add(usuario);
            _db.SaveChanges();
        }
        public IEnumerable<Usuario> GetAllUsers()
        {
            var users = new List<Usuario>();
            //var xd = new List<GetUserResult>();
            users = _db.Usuarios.ToList();
            return users;
        }
        public void EditarUsuario(int idUser, Usuario user)
        {
            throw new NotImplementedException();
        }

       

        public Usuario GetUsuarioByEmailAndPassword(string correo, string clave)
        {
            Usuario user = _db.Usuarios.Where(u => u.Email == correo).FirstOrDefault();
            if (user == null) { return null; }
            if (user.Email == correo && user.Contraseña == clave)
            {
                return user;
            }
            return null;
        }

        public Usuario GetUsuarioByID(int? IdUsuario)
        {
            var usr = _db.Usuarios.Where(x => x.UsuarioId == IdUsuario).FirstOrDefault();
            Usuario user=new Usuario();
            user.UsuarioId = usr.UsuarioId;
            user.Nombres = usr.Nombres; 
            user.Email = usr.Email;
            user.ApellidoPaterno = usr.ApellidoPaterno;
            user.ApellidoMaterno = usr.ApellidoMaterno;
            user.Contraseña = usr.Contraseña;
            user.Usuarioname= usr.Usuarioname;

            return user;
        }
    }
}
