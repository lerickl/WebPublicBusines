using WebApplication1.DataDb;
using WebApplication1.Models.viewModels;
using WebApplication1.Servicios.Interfaces;

namespace WebApplication1.Servicios
{
    public class ImagenService:IImagenService
    {
        public readonly WebeOContext _db;
        public readonly ICloudinaryService _cloudService;
        public ImagenService(WebeOContext db, ICloudinaryService cloudService)
        { 
            this._db = db;
            this._cloudService = cloudService;  
        }

        public void AddImagen(List<IFormFile> imagen, int idInmueble)
        {
            throw new NotImplementedException();
        }
        public string AddImagenPerfil(UsuarioViewModel imagen, int? UserID)
        {
           
                var img = new ImagenUser();
                if (imagen != null)
                {
                    img.UserId = UserID;
                    var imgupload = _cloudService.uploadImg(imagen.imgperfil);
                    img.url = imgupload;
                    _db.ImagenUser.Add(img);
                    _db.SaveChanges();
                }
                return img.url;
        }

        public string AddImagenPerfilEmpresa(EmpresaViewModel imagen, int? UserID)
        {
            var img = new ImagenEmpresa();
            if (imagen != null)
            {
                img.EmpresaId = UserID;
                var imgupload = _cloudService.uploadImg(imagen.imgperfil);
                img.url = imgupload;
                _db.ImagenEmpresa.Add(img);
                _db.SaveChanges();
            }
            return img.url;
        }

        public string AddImagenProd(IFormFile imagen)
        {

            string img;
            if (imagen != null)
            {                
                var imgupload = _cloudService.uploadImg(imagen);
                img = imgupload;
                return img;
         
            }
            return null;
        }
        public string AddImagenServic(IFormFile imagen)
        {

            string img;
            if (imagen != null)
            {
                var imgupload = _cloudService.uploadImg(imagen);
                img = imgupload;
                return img;

            }
            return null;
        }

     

        public void DelImg(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ImagenUser> GetAllImagenesByInmuebleID(int InmuebleId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ImagenUser> GetImagenes()
        {
            throw new NotImplementedException();
        }

        public ImagenUser GetImagenesByInmuebleId(int InmuebleId)
        {
            throw new NotImplementedException();
        }
    }
}
