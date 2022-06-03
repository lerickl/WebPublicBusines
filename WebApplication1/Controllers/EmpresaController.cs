using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DataDb;
using WebApplication1.Models.viewModels;
using WebApplication1.Servicios.Interfaces;

namespace WebApplication1.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IEmpresaService emprserv;
        private readonly IAuthService authService;
        private readonly ISessionService sessionService;
        private readonly IProductoService productoService;
        private readonly IServicioService servicioService;
        private readonly IImagenService imagenService;
        private readonly ICategoriaService categoriaService;
        public EmpresaController(IEmpresaService _emprserv, IAuthService _authService, ISessionService _sessionService, IProductoService _productoService, IServicioService _servicioService, IImagenService _imagenService, ICategoriaService _categoriaService)
        {
            this.emprserv= _emprserv;
            this.authService= _authService;
            this.sessionService= _sessionService;
            this.productoService= _productoService;
            this.servicioService= _servicioService;
            this.imagenService= _imagenService;
            this.categoriaService= _categoriaService;


        }

        // GET: EmpresaController
        public ActionResult Index()
        {
            ViewBag.productos = productoService.GetAllProducts();
            ViewBag.servicios = servicioService.GetAllServicio();
            return View();
        }
        [HttpGet]
        public IActionResult Profile() {
            ViewBag.empresa = authService.GetLogedEmpr();

            return View();
        }
        [HttpPost]
        public IActionResult Profile(EmpresaViewModel empresa)
        {
            var empr = authService.GetLogedEmpr();
            var empresa1 = new Empresa();
            empresa1.Email = empresa.Email;
            empresa1.NombreComercial = empresa.NombreComercial;
            empresa1.Telefono = empresa.Telefono;
            empresa1.Ruc = empresa.Ruc;

            empresa1.ImagenEmpresaIurl = imagenService.AddImagenPerfilEmpresa(empresa, empr.EmpresaId);

            ViewBag.empresa = empresa1;

            return View();
        }
        // GET: EmpresaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        // post: EmpresaController/Create
        [HttpPost]
        public ActionResult Create(Empresa empr)
        {
            emprserv.addEmpresa(empr);
            return RedirectToAction("index", "home");
        }
        [HttpGet]
        public IActionResult Productos()
        {
            var Empresa = authService.GetLogedEmpr();
            ViewBag.productos = productoService.GetProductoByID(Empresa.EmpresaId);
            ViewBag.categorias= categoriaService.GetAllCategoria();

            return View();
        }
        [HttpGet]
        public IActionResult Servicios()
        {
            var Empresa = authService.GetLogedEmpr();
            ViewBag.servicios=servicioService.GetAllServicioListById(Empresa.EmpresaId);
            return View();
        }
        [HttpGet]
        public ActionResult AddServicio()
        {
            return View();

        }
        [HttpPost]
        public ActionResult AddServicio(ServicioViewModel model )
        {
            var user = authService.GetLogedEmpr();
            string urlImgServic = imagenService.AddImagenProd(model.imgperfilServicio);
            var serv = new Servicio();
            serv.Nombre = model.Nombre;
            serv.EmpresaId = user.EmpresaId;
            serv.TipoServicio = model.TipoServicio;
            serv.ImagenS = urlImgServic;
            serv.Descripcion = model.Descripcion;
            serv.Precio = model.Precio;
            servicioService.AddServicio(serv);

            ViewBag.producto = new ProductoViewModel();
            return RedirectToAction("Servicios", "empresa");
        }
        [HttpGet]
        public ActionResult AddProducto()
        {
            ViewBag.categoria = categoriaService.GetAllCategoria();

            return View();
        }

        [HttpPost]
        public ActionResult AddProducto(ProductoViewModel model)
        {
            var user= authService.GetLogedEmpr();
            string urlImgProd = imagenService.AddImagenProd(model.imgperfilProducto);
            var prod = new Producto();
            prod.Nombre = model.Nombre;
            prod.EmpresaId = user.EmpresaId;
            prod.Marca=model.Marca;
            prod.ImagenP = urlImgProd;
            prod.Descripcion= model.Descripcion;    
            prod.Precio = model.Precio;
            prod.CategoriaId = model.Categoria;
            productoService.addProduct(prod);

           /* ViewBag.producto = new ProductoViewModel()*/;
            return RedirectToAction("Productos", "empresa");

        }
       
        [HttpGet]
        public ActionResult dashboard()
        {
            return View();
        }
        
        // POST: EmpresaController/Create

    }
}
