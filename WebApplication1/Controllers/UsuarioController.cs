using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication1.DataDb;
using WebApplication1.Models.viewModels;
using WebApplication1.Servicios.Interfaces;

namespace WebApplication1.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IAuthService auth;
        private readonly ISessionService sessionService;
        private readonly IImagenService imagenService;
        private readonly IProductoService productoService;
        private readonly IServicioService servicioService;

        public UsuarioController(IAuthService _auth, ISessionService _sessionService, IImagenService _imagenService, IProductoService _productoService, IServicioService _servicioService) { 
            this.auth = _auth;
            this.sessionService = _sessionService;
            this.imagenService = _imagenService;
            this.productoService = _productoService;
            this.servicioService = _servicioService;
        }

        // GET: UsuarioController
        public ActionResult Index()
        {
            ViewBag.productos= productoService.GetAllProducts();
            ViewBag.servicios = servicioService.GetAllServicio();
            return View();
        }
        public ActionResult dashboard()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Productos()
        {
            ViewBag.productos = productoService.GetAllProducts();
            return View();

        }
        [HttpPost]
        public ActionResult Productos(UsuarioViewModel model)
        {
           
            return View();
        }
        public ActionResult Servicios()
        {
            ViewBag.servicios=servicioService.GetAllServicio();
            return View();
        }
        [HttpGet]
        public ActionResult Profile()
        {
            var user = auth.GetLogedUser();
            ViewBag.Usuario = user;
            return View();
       
        }
        [HttpPost]
        public async Task<IActionResult> Profile(UsuarioViewModel usuario)
        {
            Usuario usr = auth.GetLogedUser();
            usr.Nombres = usuario.Nombres;   
            usr.ApellidoPaterno = usuario.ApellidoPaterno;
            usr.ApellidoMaterno = usuario.ApellidoMaterno;
            usr.Email = usuario.Email;
            usr.ImagenUserIurl=imagenService.AddImagenPerfil(usuario, usr.UsuarioId);             
            
            ViewBag.usuario = usr;
           
            return View();

        }

        [HttpGet]
        public IActionResult test()
        {
            ViewBag.Usuario = new Usuario();
            return View();
            #region session set area
             
            #endregion
        }
        [HttpPost]
        public async Task<IActionResult> test(data data)
        {
            if (data.imgperfil == null)
                return View(data);

            string uploadsFolder = Path.Combine("", "Your upload path");
            string ImagePath = Guid.NewGuid().ToString() + "_" + data.name;
            string filePath = Path.Combine(uploadsFolder, ImagePath);
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                await data.imgperfil.CopyToAsync(fs);
            }
            if (data != null)
            {
                 
                //bookModel.CoverImageUrl = await UploadImage(folder, imgperfil);
            }
            
            return View();
        }
    

        // GET: UsuarioController/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult AddProducto() {
        
            return View();
        }
        [HttpPost]
        public ActionResult AddProducto(ProductoViewModel model)
        {
            ViewBag.producto=new ProductoViewModel();
            return View();
        }
        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Produc(int id) {           
            ViewBag.Product = productoService.GetProductById(id);
            ViewBag.Comentarios = null;
            return View();
        }
        [HttpGet]
        public IActionResult serv(int id)
        {


            ViewBag.serv = servicioService.GetServicioByID(id);
            return View();
        }
        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
