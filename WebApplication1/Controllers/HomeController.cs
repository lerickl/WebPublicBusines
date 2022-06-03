using Microsoft.AspNetCore.Mvc;
using System.Diagnostics; 
using WebApplication1.DataDb;
using WebApplication1.Models.viewModels;
using WebApplication1.Servicios.Interfaces;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUsuarioService userserv;
        private readonly IEmpresaService EmpresaService;
        private readonly ISessionService sessionService;
        private readonly IAuthService AuthService;
        private readonly IHttpContextAccessor _context;
        private readonly ICategoriaEmpresa categoriaEmpresa;
        private readonly IValidacionesService validar;
        public HomeController(IHttpContextAccessor context, IUsuarioService _userserv, IEmpresaService _EmpresaService, ISessionService _sessionService, IAuthService _AuthService, ICategoriaEmpresa _categoriaEmpresa, IValidacionesService _validar)
        {
            this._context = context;
            this.userserv = _userserv;
            this.EmpresaService = _EmpresaService;
            this.sessionService = _sessionService;
            this.AuthService = _AuthService;
            this.categoriaEmpresa = _categoriaEmpresa;
            this.validar = _validar;
        }

        public IActionResult Index()
        {


            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register([FromBody] UserRegistro user)
        {
            var error = validar.ValidarUser(user);
            var usr = new Usuario();
            usr.Nombres = user.Nombre;
            usr.Email = user.Email;
            usr.Contraseña = user.Password;

            if (error.Error == "200")
            {
                userserv.AddUsuario(usr);       
                sessionService.GuardarSessionUsr(usr, _context);
                return Json(error);
            }

            return Json(error);
        }
        [HttpPost]
        public IActionResult RegistrarEmpr([FromBody] EmpresaRegistro empresa) {
            var error=validar.ValidarEmpresa(empresa);
            var Empresa=new Empresa();

            Empresa.NombreComercial = empresa.NombreComercial;             
            Empresa.Telefono = empresa.Telefono;
            Empresa.Email = empresa.Email;
            Empresa.Contraseña = empresa.Password;

            if ( error.Error=="200"){
                EmpresaService.addEmpresa(Empresa);
                sessionService.GuardarSessionEmpr(Empresa, _context);
                return Json(error);
            }
             
            return Json(error);
        }
        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login([FromBody] DataLogin usuario)
        {
            errorVue temp = new errorVue();
            if (usuario.email != null || usuario.password != null)
            {
                if (usuario.email == null|| usuario.email=="") {
                    temp.text = "1";
                    temp.Content = "Ingrese su Email";
                    return Json(temp);
                }else if(usuario.password == null || usuario.password=="")
                {
                    temp.text = "2";
                    temp.Content = "Ingrese su Contraseña";
                    return Json(temp);
                }
                string tipouser = AuthService.Login(usuario.email, usuario.password);
                if (tipouser!=null){
                    if (tipouser == "usuario")
                    {
                        temp.text = "3";
                        temp.Content = "usuario";
                        //return RedirectToAction("Index", "usuario");
                        return Json(temp);
                    }
                    else if (tipouser == "empresa")
                    {
                        temp.text = "3";
                        temp.Content = "empresa";
                        return Json(temp);
                    }
                     
                }
                temp.text = "4";
                temp.Content = "email o contraseña incorrectos";
                return Json(temp);

            }

            temp.text = "5";
            temp.Content = "Ingresa Email y contraseña";

            usuario.email = "testcontrooller";
            usuario.password = "test";
            return Json(temp);
              
        }
        public IActionResult Privacy()
        {
            return View();
        }

     
      
    }
}