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
        private readonly IUsuarioService usuarioService;
        private readonly ICategoriaService categoriaserv;
        private readonly IEmpresaService empresaserv;

        public UsuarioController(IAuthService _auth, ISessionService _sessionService, IImagenService _imagenService, IProductoService _productoService, IServicioService _servicioService, IUsuarioService _usuarioService, ICategoriaService _categoriaserv, IEmpresaService _empresaserv) { 
            this.auth = _auth;
            this.sessionService = _sessionService;
            this.imagenService = _imagenService;
            this.productoService = _productoService;
            this.servicioService = _servicioService;
            this.usuarioService = _usuarioService;
            this.categoriaserv = _categoriaserv;
            this.empresaserv = _empresaserv;
        }

        // GET: UsuarioController
        public ActionResult Index()
        {
            ViewBag.productos= productoService.GetAllProducts();
            ViewBag.servicios = servicioService.GetAllServicio();
            ViewBag.categoria = categoriaserv.GetAllCategoria();
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
            ViewBag.categoria = categoriaserv.GetAllCategoria();
            ViewBag.servicios = servicioService.GetAllServicio();
            return View();

        }
    
        [HttpGet]
        public ActionResult Servicios()
        {
            ViewBag.categoria = categoriaserv.GetAllCategoria();
            ViewBag.servicios=servicioService.GetAllServicio();
            return View();
        }
        [HttpGet]
        public ActionResult Profile()
        {
            var user=new Usuario();
            try {
                  user = auth.GetLogedUser();
            }
            catch (Exception e)
            {
                user = null;
            }

            ViewBag.Usuario = user;
            return View();
       
        }
        [HttpPost]
        public IActionResult Profile(UsuarioViewModel usuario)
        {

            var usr = new Usuario();
            try {
                usr = auth.GetLogedUser();
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Home");
            }
         
            usr.Nombres = usuario.Nombres;   
            usr.ApellidoPaterno = usuario.ApellidoPaterno;
            usr.ApellidoMaterno = usuario.ApellidoMaterno;
            usr.Email = usuario.Email;
            if (usuario.isperfil == "true")
            {
                usr.ImagenUserIurl = usr.ImagenUserIurl;
            }
            else
            {
                if (usuario.imgperfil == null)
                {
                    usr.ImagenUserIurl = null;
                }
                else
                {
                    usr.ImagenUserIurl = imagenService.AddImagenPerfil(usuario, usr.UsuarioId);

                }
            }
            usuarioService.EditarUsuario(usr.UsuarioId,usr);
            ViewBag.usuario = usr;
           
            return View();

        }
        [HttpGet]
        public IActionResult test()
        {
            ViewBag.Usuario = new Usuario();
            return View();
     
        }        
        [HttpPost]
        public IActionResult Valoracion(int valoracion) {


            return Json("");
        
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
        [HttpGet]
        public ActionResult AddProducto() {
        
            return View();
        }    
        [HttpGet]
        public IActionResult Produc(int id) {
            var prod = productoService.GetProductByIdP(id);
            ViewBag.empresa = empresaserv.GetEmpresaByID(prod.EmpresaId).NombreComercial;

            ViewBag.Product = prod;
            ViewBag.Comentarios = null;
            return View();
        }
        [HttpGet]
        public IActionResult serv(int id)
        {
            var serv = servicioService.GetServicioByID(id);
            ViewBag.serv = serv;
            ViewBag.empresa = empresaserv.GetEmpresaByID(serv.EmpresaId).NombreComercial;


            return View();
        }
        

        [HttpGet]
        public IActionResult search()
        {
            ViewBag.productos = new List<Producto>();
            ViewBag.categoria = categoriaserv.GetAllCategoria();
            ViewBag.servicios = new List<Servicio>();

            return View();
        }
        [HttpPost]
        public IActionResult Search(Search search)
        {
            var prod = productoService.search(search);
            var serv = servicioService.search(search);
            if (prod == null && serv == null)
            {
                ViewBag.productos = new List<Producto>();
                ViewBag.categoria = categoriaserv.GetAllCategoria();
                ViewBag.servicios = new List<Servicio>();

            }
            if (prod != null && serv == null)
            {

                ViewBag.productos = prod;
                ViewBag.categoria = categoriaserv.GetAllCategoria();
                ViewBag.servicios = new List<Servicio>();
            }
            if (prod == null && serv != null)
            {

                ViewBag.productos = new List<Producto>();
                ViewBag.categoria = categoriaserv.GetAllCategoria();
                ViewBag.servicios = serv;
            }
            if (prod != null && serv != null)
            {

                ViewBag.productos = prod;
                ViewBag.categoria = categoriaserv.GetAllCategoria();
                ViewBag.servicios = serv;
            }

            //var result = EmpresaService.Search(busqueda);   

            return View();
        }
        [HttpGet]
        public IActionResult E(int id)
        {
            EmpresaVM datos = new EmpresaVM();
            var tmp = empresaserv.GetEmpresaByID(id);
            datos.NombreComercial = tmp.NombreComercial;
            datos.Telefono = tmp.Telefono;
            datos.Email = tmp.Email;
            datos.Direccion = tmp.Direccion;
            datos.Ruc = tmp.Ruc;
            datos.ImagenEmpresaIurl = tmp.ImagenEmpresaIurl;
            ViewBag.Empresa = datos;
            return View();
        }

    }
}
