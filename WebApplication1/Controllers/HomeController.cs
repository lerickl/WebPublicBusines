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

        public HomeController(IUsuarioService _userserv)
        {
            this.userserv = _userserv;
        }
        
        public IActionResult Index()
        {
            
           
            return View();
        }
        public IActionResult Register()
        {
            return View();
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
            if (user != null)
            {
                //autentication.Login(user);
               // session.GuardarSession(user);

                return RedirectToAction("Index", "Usuario");
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