using WebApplication1.DataDb;
using WebApplication1.Models.viewModels;

namespace WebApplication1.Servicios.Interfaces
{
    public interface IImagenService
    {
        void AddImagen(List<IFormFile> imagen, int idInmueble);
        IEnumerable<ImagenUser> GetImagenes();
        ImagenUser GetImagenesByInmuebleId(int InmuebleId);
        IEnumerable<ImagenUser> GetAllImagenesByInmuebleID(int InmuebleId);
        void DelImg(int id);
        public string AddImagenPerfil(UsuarioViewModel imagen, int? UserID);
        public string AddImagenProd(IFormFile imagen);
        public string AddImagenServic(IFormFile image);
        string AddImagenPerfilEmpresa(EmpresaViewModel imagen, int? UserID);
        //List<JsonImagen> getAllImgs();
    }
}
