using System.Text.RegularExpressions;
using WebApplication1.DataDb;
using WebApplication1.Models;
using WebApplication1.Models.viewModels;
using WebApplication1.Servicios.Interfaces;

namespace WebApplication1.Servicios
{
    public class ValidarService : IValidacionesService
    {

        private readonly WebeOContext _db;
        public ValidarService(WebeOContext db) {
            this._db = db;
        }
        public ErrorVal ValidarEmpresa(EmpresaRegistro empresa)
        {
            var Error = new ErrorVal();
            string LetrasRegex = @"^[a-zA-Z\s]+$";
            string NumerosRegex = @"^(0|[1-9]\d*)$";
            string EmailRegex = @"^(('[\w-\s]+')|([\w-]+(?:\.[\w-]+)*)|('[\w-\s]+')([\w-]+(?:\.[\w-]+)*))(@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$)|(@\[?((25[0-5]\.|2[0-4][0-9]\.|1[0-9]{2}\.|[0-9]{1,2}\.))((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\.){2}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\]?$)";
            if (empresa.Email==null)
            {
                Error.Error = "Email";
                Error.Message = "Ingrese su Email ";
                return Error;
            }else if (empresa.Email.Length <= 0)
            {
                Error.Error = "Email";
                Error.Message = "Tiene que tener al menos un caracter ";
                return Error;
            }
            else if (empresa.Email.Length > 100)
            {
                Error.Error = "Email";
                Error.Message = "No puede tener mas de 100 caracteres";
                return Error;
            }
         
            bool isEmailValid = Regex.IsMatch(empresa.Email, EmailRegex);
            if (!isEmailValid)
            {
                Error.Error = "Email";
                Error.Message = "Ingrese un Email Correcto ";
                return Error;
            }
            if (emailRegistrado(empresa.Email))
            {
                Error.Error = "Email";
                Error.Message = "Email ya registrado";
                return Error;
            }


            if (string.IsNullOrEmpty(empresa.NombreComercial))
            {
                Error.Error = "NombreComercial";
                Error.Message = "Ingrese Nombre Comercial ";
                return Error;
            }
            if (empresa.NombreComercial.Length <= 0)
            {
                Error.Error = "NombreComercial";
                Error.Message = "Tiene que tener al menos un caracter ";
                return Error;
            }
            if (empresa.NombreComercial.Length > 100)
            {
                Error.Error = "NombreComercial";
                Error.Message = "No puede tener mas de 100 caracteres";
                return Error;
            }
               
            bool isNombreValid =  Regex.IsMatch(empresa.NombreComercial, LetrasRegex);
            if (!isNombreValid){
                Error.Error = "NombreComercial";
                Error.Message = "Solo se aceptan letras";
                return Error;
            }
            //
            if (string.IsNullOrEmpty(empresa.Telefono))
            {
                Error.Error = "Telefono";
                Error.Message = "Ingrese su telefono";

                return Error;
            }
            bool tel = Regex.IsMatch(empresa.Telefono, NumerosRegex);
            if (!tel)
            {
                Error.Error = "Telefono";
                Error.Message = "Ingrese solo numeros ";
                return Error;
            }
            if (empresa.Password==null) 
            {
                Error.Error = "Contraseña";
                Error.Message = "Ingrese su contraseña";
                return Error;
            }
            

            Error.Error = "200";
            Error.Message = "Email correcto";

            return Error;
            
        }
        public bool emailRegistrado(string Email) {
            var eEmail= _db.Usuarios.Where(e => e.Email == Email).FirstOrDefault();
            var uEmail= _db.Empresas.Where(u => u.Email == Email).FirstOrDefault();

            if (eEmail == null&&uEmail==null) 
            {
                return false;
            }return true;
        }
        public ErrorVal ValidarUser(UserRegistro user)
        {
            var Error = new ErrorVal();
            string LetrasRegex = @"^[a-zA-Z\s]+$";
            string NumerosRegex = @"^(0|[1-9]\d*)$";
            string EmailRegex = @"^(('[\w-\s]+')|([\w-]+(?:\.[\w-]+)*)|('[\w-\s]+')([\w-]+(?:\.[\w-]+)*))(@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$)|(@\[?((25[0-5]\.|2[0-4][0-9]\.|1[0-9]{2}\.|[0-9]{1,2}\.))((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\.){2}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\]?$)";
            if (user.Nombre==null)
            {
                Error.Error = "Nombre";
                Error.Message = "Ingrese Nombre  ";
                return Error;
            }
            if (user.Nombre.Length <= 0)
            {
                Error.Error = "Nombre";
                Error.Message = "Tiene que tener al menos un caracter ";
                return Error;
            }
            if (user.Nombre.Length > 100)
            {
                Error.Error = "Nombre";
                Error.Message = "No puede tener mas de 100 caracteres";
                return Error;
            }

            bool isNombreValid = Regex.IsMatch(user.Nombre, LetrasRegex);
            if (!isNombreValid)
            {
                Error.Error = "Nombre";
                Error.Message = "Solo se aceptan letras";
                return Error;
            }
            if (user.Email == null)
            {
                Error.Error = "Email";
                Error.Message = "Ingrese su Email ";
                return Error;
            }
            else if (user.Email.Length <= 0)
            {
                Error.Error = "Email";
                Error.Message = "Tiene que tener al menos un caracter ";
                return Error;
            }
            else if (user.Email.Length > 100)
            {
                Error.Error = "Email";
                Error.Message = "No puede tener mas de 100 caracteres";
                return Error;
            }

            bool isEmailValid = Regex.IsMatch(user.Email, EmailRegex);
            if (!isEmailValid)
            {
                Error.Error = "Email";
                Error.Message = "Ingrese un Email Correcto ";
                return Error;
            }
            if (emailRegistrado(user.Email))
            {
                Error.Error = "Email";
                Error.Message = "Email ya registrado";
                return Error;
            }
            if (user.Password == null)
            {
                Error.Error = "Contraseña";
                Error.Message = "Ingrese su contraseña";
                return Error;
            }


            Error.Error = "200";
            Error.Message = "Email correcto";

            return Error;
        }

        public bool ValidarUsuario()
        {
            throw new NotImplementedException();
        }
    }
}
