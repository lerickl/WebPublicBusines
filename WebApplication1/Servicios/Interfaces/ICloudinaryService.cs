using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.Web;
namespace WebApplication1.Servicios.Interfaces
{
    public interface ICloudinaryService
    {
        string uploadImg(IFormFile imagePath);
    }
    public class CloudinaryService : ICloudinaryService
    {
        public static Cloudinary cloudinary;
        Account account = new Account(
                "lbusinesscloudl",
                "979427328292796",
                "i1U9RGs6KgIzavbQDotoxzWbu9Q"
            );
        public CloudinaryService()
        {

            cloudinary = new Cloudinary(account);
            //cloudinary.Upload();


        }
        public string uploadImg(IFormFile ImagePath) {
            var uploading = new ImageUploadParams();
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(ImagePath.Name,ImagePath.OpenReadStream())
            };

            var uploadResult = cloudinary.Upload(uploadParams).Uri;

            return uploadResult.ToString();
        }
        //public string uploadImg(FileManagement imagePath)
        //{

        //    var uploadImg = new ImageUploadParams()
        //    {
        //        File = new FileDescription(imagePath.FileName, imagePath.)
        //    };

        //    var uploadResult = cloudinary.Upload(uploadImg).Uri;
        //    var dato = uploadResult;
        //    return dato.ToString();
        //}
    }
}
