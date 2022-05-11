using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DataDb;
using WebApplication1.Servicios.Interfaces;

namespace WebApplication1.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IEmpresaService emprserv;
        public EmpresaController(IEmpresaService _emprserv)
        {
            this.emprserv= _emprserv;
        }

        // GET: EmpresaController
        public ActionResult Index()
        {
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
        public ActionResult Productos()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Servicios()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddProducto()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddServicio()
        {
            return View();
        }
        [HttpGet]
        public ActionResult dashboard()
        {
            return View();
        }
        
        // POST: EmpresaController/Create

    }
}
