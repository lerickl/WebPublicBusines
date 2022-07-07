using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Controllers;
using WebApplication1.DataDb;
using WebApplication1.Models.viewModels;
using WebApplication1.Servicios;
using WebApplication1.Servicios.Interfaces;

namespace TestProject1.PruebasUnitarias
{
    [TestFixture]
    public class UnitariasHomeControllerTest
    {
        
        [Test]
        public void EsValidoGetIndexViewCategoria()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService,
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var index = homeControllerTest.Index() as ViewResult;
            var categorias = new List<Categoria>();
            
            Assert.IsNotNull(index.ViewData["Categoria"]);

        }
        [Test]
        public void EsValidoGetIndex()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService,
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var index = homeControllerTest.Index();
            Assert.IsInstanceOf<ViewResult>(index);

        }
        [Test]
        public void EsValidoGetRegister()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService,
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var reg = homeControllerTest.Register();
            Assert.IsInstanceOf<ViewResult>(reg);

        }
        [Test]
        public void EsValidoGetLogin()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService,
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var login = homeControllerTest.Login();
            Assert.IsInstanceOf<ViewResult>(login);

        }
        [Test]
        public void EsValidoRegisterPost()
        {
            var usr = new UserRegistro();
            usr.Nombre = "Nombre";
            usr.Email = "email@Email.com";
            usr.Password = "123123";
            
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService, 
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var reg = homeControllerTest.Register(usr);
            Assert.IsInstanceOf<JsonResult>(reg);

        }
        [Test]
        public void EsValidoPostRegisterEmpr()
        {
            var usr = new EmpresaRegistro();
            usr.NombreComercial = "Nombre";
            usr.Email = "email@Email.com";
            usr.Password = "123123";
            usr.Telefono = "976765654";
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService,
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var regemp = homeControllerTest.RegistrarEmpr(usr);
            Assert.IsInstanceOf<JsonResult>(regemp);
            
        }
        [Test]
        public void EsValidoPostLogin()
        {
            var dat = new DataLogin();
            dat.email = "Test@test.com";
            dat.password = "a2312_";
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService, 
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var login = homeControllerTest.Login(dat);
            Assert.IsInstanceOf<JsonResult>(login);

        }
        [Test]
        public void EsValidoprivaci()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService,
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var prv = homeControllerTest.Privacy();
            Assert.IsInstanceOf<ViewResult>(prv);

        }
        [Test]
        public void EsValidoGetSearch()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService,
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var prv = homeControllerTest.search();
            Assert.IsInstanceOf<ViewResult>(prv);

        }
        [Test]
        public void EsValidoGetSearchViewBagProductos()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService, 
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var search = homeControllerTest.search() as ViewResult;
            Assert.IsNotNull(search.ViewData["productos"]);

        }
        [Test]
        public void EsValidoGetSearchViewBagcategoria()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService,
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var search = homeControllerTest.search() as ViewResult;
            Assert.IsNotNull(search.ViewData["categoria"]);

        }
        [Test]
        public void EsValidoGetSearchViewBagservicios()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService,
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var search = homeControllerTest.search() as ViewResult;
            Assert.IsNotNull(search.ViewData["servicios"]);

        }
        [Test]
        public void EsValidoPostSearch()
        {
            var busqueda = new Search();
            busqueda.categoria = 1;
            busqueda.busqueda = "telefonos";
            
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService, 
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var search = homeControllerTest.Search(busqueda);
            Assert.IsInstanceOf<ViewResult>(search);

        }
        [Test]
        public void EsValidoPostSearchBagProductos()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService, 
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var search = homeControllerTest.Search(new Search()) as ViewResult;

            Assert.IsNotNull(search.ViewData["productos"]);

        }
        [Test]
        public void EsValidoPostSearchViewBagcategoria()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService,
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var search = homeControllerTest.Search(new Search()) as ViewResult;

            Assert.IsNotNull(search.ViewData["categoria"]);

        }
        [Test]
        public void EsValidoPostSearchViewBagservicios()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService, 
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var search = homeControllerTest.Search(new Search()) as ViewResult;

            Assert.IsNotNull(search.ViewData["servicios"]);
          

        }
        [Test]
        public void EsValidoPostserv()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);            
            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService, 
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var search = homeControllerTest.serv(1) ;

            Assert.IsInstanceOf<ViewResult>(search);


        }
        [Test]
        public void EsValidoPostServViewbagserv()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            
            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService, 
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var search = homeControllerTest.serv(1) as ViewResult;

            Assert.IsNull(search.ViewData["serv"]);

            
        }
        [Test]
        public void EsValidoGetproduct()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService, 
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var search = homeControllerTest.product(1);

            Assert.IsInstanceOf<ViewResult>(search);


        }
        [Test]
        public void EsValidoPostServViewbagproduct()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var IEmpresaService = new EmpresaService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IValidacionesService = new ValidarService(WebContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);

            var homeControllerTest = new HomeController(httpContext, UsuarioService, IEmpresaService, 
                ISessionService, IAuthService, IValidacionesService, IProductoService, IServicioService, ICategoriaService);
            var search = homeControllerTest.product(1) as ViewResult;

            Assert.IsNull(search.ViewData["Product"]);


        }

    }
}
