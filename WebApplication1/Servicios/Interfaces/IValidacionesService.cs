using CloudinaryDotNet.Actions;
using WebApplication1.Models;
using WebApplication1.Models.viewModels;

namespace WebApplication1.Servicios.Interfaces
{
    public interface IValidacionesService
    {
        ErrorVal ValidarEmpresa(EmpresaRegistro empresa);
        ErrorVal ValidarUser(UserRegistro user);
        bool ValidarUsuario();
    }
}
