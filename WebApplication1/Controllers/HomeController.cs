using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.DataDb;

using WebApplication1.Servicios.Interfaces;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
         
        private readonly IUsuarioService userserv;
        private readonly IEmpresaService EmpresaService;


        public HomeController(IUsuarioService _userserv, IEmpresaService _EmpresaService)
        {
            this.userserv = _userserv;
            this.EmpresaService = _EmpresaService;
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
        public IActionResult Register(Usuario user)
        {
            userserv.AddUsuario(user);

            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Email,string Contraseña)
        {
            if (Email == "" || Contraseña == "")
            {

                //ViewBag.ShowModalLogin = true;
                //ModelState.AddModelError("Cuenta", "Email o Password Incorrectos!");
                return View();

            }
            Usuario user = userserv.GetUsuarioByEmailAndPassword(Email, Contraseña);
            Empresa empr = EmpresaService.GetEmpresaByEmailAndPassword(Email, Contraseña);
            if (user == null && empr == null) 
            {
                return RedirectToAction("Index", "Home");
            }
            
            if (user != null)
            {
                //autentication.Login(user);
               // session.GuardarSession(user);

                return RedirectToAction("Index", "Usuario");
            }else if (empr != null)
            {
                //autentication.Login(user);
                // session.GuardarSession(user);

                return RedirectToAction("Index", "Empresa");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
        public IActionResult Privacy()
        {
            return View();
        }

     
      
    }
}