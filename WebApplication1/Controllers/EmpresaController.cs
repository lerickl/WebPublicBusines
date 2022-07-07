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
            ViewBag.categoria = categoriaService.GetAllCategoria();
            return View();
        }
        [HttpGet]
        public IActionResult Profile() {
            try {
                ViewBag.empresa = authService.GetLogedEmpr();
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Profile(EmpresaViewModel empresa)
        {
            var empr = new Empresa();
            try {
                empr = authService.GetLogedEmpr();
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Home");
            }
            
            
            empr.Email = empresa.Email;
            empr.NombreComercial = empresa.NombreComercial;
            empr.Telefono = empresa.Telefono;
            empr.Ruc = empresa.Ruc;
            empr.Direccion = empresa.Direccion;
            if (empresa.isperfil == "true")
            {
                empr.ImagenEmpresaIurl = empr.ImagenEmpresaIurl;
            }
            else 
            {
                if (empresa.imgperfil == null)
                {
                    empr.ImagenEmpresaIurl = null;
                }
                else
                {
                    empr.ImagenEmpresaIurl = imagenService.AddImagenPerfilEmpresa(empresa, empr.EmpresaId);

                }
            }
           
            emprserv.EditarEmpresa(empr.EmpresaId, empr);
            ViewBag.empresa = empr;

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
            var empresa = new Empresa();
            try {
                empresa = authService.GetLogedEmpr();
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.productos = productoService.GetProductoByID(empresa.EmpresaId);
            ViewBag.categorias= categoriaService.GetAllCategoria();

            return View();
        }
        [HttpGet]
        public IActionResult Servicios()
        {
            var Empresa = new Empresa();
            try { Empresa = authService.GetLogedEmpr(); }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Home");
            }
           
            ViewBag.servicios=servicioService.GetAllServicioListById(Empresa.EmpresaId);
            return View();
        }
        [HttpGet]
        public ActionResult AddServicio()
        {
            ViewBag.categoria = categoriaService.GetAllCategoria();

            return View();

        }
        [HttpPost]
        public ActionResult AddServicio(ServicioViewModel model )
        {
            var user =new Empresa();
            try { user = authService.GetLogedEmpr(); }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Home");
            }
          
            string urlImgServic;
            urlImgServic = imagenService.AddImagenServic(model.imgperfilServicio);
           
            var serv = new Servicio();
            serv.Nombre = model.Nombre;
            serv.EmpresaId = user.EmpresaId;
            serv.TipoServicio = model.TipoServicio;
            serv.ImagenS = urlImgServic;
            serv.Descripcion = model.Descripcion;
            serv.Precio = model.Precio;
            if (model.CategoriaId == 0)
            {
                serv.CategoriaId = null;
            }
            else
            {
                serv.CategoriaId = model.CategoriaId;
            }
            servicioService.AddServicio(serv);

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
            var user = new Empresa();
            try { user = authService.GetLogedEmpr(); }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Home");
            }
            
            string urlImgProd = imagenService.AddImagenProd(model.imgperfilProducto);
            var prod = new Producto();
            prod.Nombre = model.Nombre;
            prod.EmpresaId = user.EmpresaId;
            prod.Marca=model.Marca;
            prod.ImagenP = urlImgProd;
            prod.Descripcion= model.Descripcion;    
            prod.Precio = model.Precio;
            if (model.Categoria == 0) {
                prod.CategoriaId = null;
            }
            else
            {
                prod.CategoriaId = model.Categoria;
            }
          
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
        [HttpGet]
        public IActionResult EditP(int Id)
        {
            ViewBag.producto = productoService.GetProductByIdP(Id);
            ViewBag.categoria = categoriaService.GetAllCategoria();
            return View();
        }
        [HttpPost]
        public IActionResult EditP(ProductoViewModel Prod) 
        {
            var produc = new Producto();
            produc = productoService.GetProductByIdP(Prod.ProductoId);
            if (produc==null) { return RedirectToAction("productos", "empresa"); }
            
           
            produc.ProductoId = Prod.ProductoId;
            produc.Nombre = Prod.Nombre;
            produc.Marca = Prod.Marca;
            produc.Descripcion = Prod.Descripcion;
            produc.Precio = Prod.Precio;
            produc.CategoriaId = Prod.Categoria;            
         
            if (Prod.EditImg=="true") 
            {
                if (Prod.imgperfilProducto != null)
                {
                    produc.ImagenP = imagenService.AddImagenProd(Prod.imgperfilProducto);
                }
                else {
                    produc.ImagenP = null;
                }
            }
            productoService.EditProduct(produc);
            return RedirectToAction("productos", "empresa");
        }
        [HttpGet]
        public IActionResult RemoveP(int Id)
        {
            var empr = new Empresa();
            try {
                empr = authService.GetLogedEmpr();
            }
            catch (Exception e)
            {
                return RedirectToAction("productos", "empresa");
            }
            
            productoService.DeletProduct(Id, empr.EmpresaId);
            return RedirectToAction("productos","empresa");
        }
        [HttpGet]
        public IActionResult EditS(int Id)
        {
            ViewBag.servicio = servicioService.GetServicioByID(Id);
            ViewBag.categoria = categoriaService.GetAllCategoria();
            return View();
        }
        [HttpPost]
        public IActionResult EditS(ServicioViewModel service)
        {
            var serv = servicioService.GetServicioByID(service.ServicioId);
            if (serv == null) {
                return RedirectToAction("servicio","empresa");
            }
            serv.ServicioId = service.ServicioId;
            serv.Nombre = service.Nombre;
            serv.TipoServicio = service.TipoServicio;
            serv.Descripcion = service.Descripcion;
            serv.Precio = service.Precio;
            serv.CategoriaId = service.CategoriaId;

            if (service.EditImg == "true")
            {
                if (service.imgperfilServicio != null)
                {
                    serv.ImagenS = imagenService.AddImagenServic(service.imgperfilServicio);
                }
                else
                {
                    serv.ImagenS = null;
                }
            }
            servicioService.EditarServicio(serv);
            return RedirectToAction("servicios", "empresa");
        }
        [HttpGet]
        public IActionResult RemoveS(int Id)
        {
            var empr = new Empresa(); ;
            try { empr = authService.GetLogedEmpr(); }
            catch (Exception e)
            {
                return RedirectToAction("servicio", "empresa");
            }
         
            servicioService.DeletServicio(Id, empr.EmpresaId);
            return RedirectToAction("servicios", "empresa");
        }
        [HttpGet]
        public IActionResult Produc(int id) {
            var prod = productoService.GetProductByIdP(id);
            ViewBag.empresa = emprserv.GetEmpresaByID(prod.EmpresaId).NombreComercial;

            ViewBag.Product = prod;
            ViewBag.Comentarios = null;
            return View();
        }
        [HttpGet]
        public IActionResult serv(int id)
        {
            var serv = servicioService.GetServicioByID(id);
            ViewBag.serv = serv;
            ViewBag.empresa = emprserv.GetEmpresaByID(serv.EmpresaId).NombreComercial;



            return View();
          
        }
        [HttpGet]
        public IActionResult E(int id)
        {
            EmpresaVM datos = new EmpresaVM();
            var tmp = emprserv.GetEmpresaByID(id);
            datos.NombreComercial = tmp.NombreComercial;
            datos.Telefono = tmp.Telefono;
            datos.Email = tmp.Email;
            datos.Direccion = tmp.Direccion;
            datos.Ruc = tmp.Ruc;
            datos.ImagenEmpresaIurl = tmp.ImagenEmpresaIurl;
            ViewBag.Empresa = datos;
            return View();
        }
        [HttpGet]
        public IActionResult search()
        {
            ViewBag.productos = new List<Producto>();
            ViewBag.categoria = categoriaService.GetAllCategoria();
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
                ViewBag.categoria = categoriaService.GetAllCategoria();
                ViewBag.servicios = new List<Servicio>();

            }
            if (prod != null && serv == null)
            {

                ViewBag.productos = prod;
                ViewBag.categoria = categoriaService.GetAllCategoria();
                ViewBag.servicios = new List<Servicio>();
            }
            if (prod == null && serv != null)
            {

                ViewBag.productos = new List<Producto>();
                ViewBag.categoria = categoriaService.GetAllCategoria();
                ViewBag.servicios = serv;
            }
            if (prod != null && serv != null)
            {

                ViewBag.productos = prod;
                ViewBag.categoria = categoriaService.GetAllCategoria();
                ViewBag.servicios = serv;
            }

            //var result = EmpresaService.Search(busqueda);   

            return View();
        }

    }
}
