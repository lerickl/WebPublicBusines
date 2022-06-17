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
    public class UnitariasUsuarioControllerTest
    {
        [Test]
        public void EsValidoGetIndex()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);

            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var index = usuarioControllerTest.Index();
            Assert.IsInstanceOf<ViewResult>(index);

        }
        [Test]
        public void EsValidoGetIndexViewBagproductos()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var index = usuarioControllerTest.Index() as ViewResult;
            Assert.IsNotNull(index.ViewData["productos"]);

        }
        [Test]
        public void EsValidoGetIndexViewBagservicios()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var index = usuarioControllerTest.Index() as ViewResult;
            Assert.IsNotNull(index.ViewData["servicios"]);

        }
        [Test]
        public void EsValidoGetIndexViewBagcategoria()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var index = usuarioControllerTest.Index() as ViewResult;
            Assert.IsNotNull(index.ViewData["categoria"]);

        }
        [Test]
        public void EsValidoGetdashboard()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var dashboard = usuarioControllerTest.dashboard();
            Assert.IsInstanceOf<ViewResult>(dashboard);

        }
        [Test]
        public void EsValidoGetProductos()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService,
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var Productos = usuarioControllerTest.Productos();
            Assert.IsInstanceOf<ViewResult>(Productos);

        }
        [Test]
        public void EsValidoGetProductosViewBagproductos()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);

            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var Productos = usuarioControllerTest.Productos() as ViewResult;
            Assert.IsNotNull(Productos.ViewData["productos"]);


        }
        [Test]
        public void EsValidoGetProductosViewBagcategoria()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService,
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var Productos = usuarioControllerTest.Productos() as ViewResult;
            Assert.IsNotNull(Productos.ViewData["categoria"]);

        }
        [Test]
        public void EsValidoGetProductosViewBagservicios()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService,
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var Productos = usuarioControllerTest.Productos() as ViewResult;
            Assert.IsNotNull(Productos.ViewData["servicios"]);

        }
        [Test]
        public void EsValidoPostProductos()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService,
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var Productos = usuarioControllerTest.Productos(new UsuarioViewModel()) ;
            Assert.IsInstanceOf<ViewResult>(Productos);

        }
        [Test]
        public void EsValidoGetServicios()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService,
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var Productos = usuarioControllerTest.Servicios();
            Assert.IsInstanceOf<ViewResult>(Productos);

        }
        [Test]
        public void EsValidoGetServiciosViewBagcategoria()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService,
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var Servicios = usuarioControllerTest.Servicios() as ViewResult;
            Assert.IsNotNull(Servicios.ViewData["categoria"]);

        }
        [Test]
        public void EsValidoGetServiciosViewBagservicios()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService,
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var Servicios = usuarioControllerTest.Servicios() as ViewResult;
            Assert.IsNotNull(Servicios.ViewData["servicios"]);

        }
        [Test]
        public void EsValidoGetProfile()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var profile = usuarioControllerTest.Profile();
            Assert.IsInstanceOf<ViewResult>(profile);

        }
        [Test]
        public void EsValidoGetProfileUserNull()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var profile = usuarioControllerTest.Profile() as ViewResult;
            Assert.IsNull(profile.ViewData["Usuario"]);

        }
        [Test]
        public void EsValidoPostProfileUser()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService,
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var profile = usuarioControllerTest.Profile(new UsuarioViewModel());
          
            Assert.IsInstanceOf<RedirectToActionResult>(profile);
        }
        [Test]
        public void EsValidoGetTest()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);  var test = usuarioControllerTest.test();            
            Assert.IsInstanceOf<ViewResult>(test);
        }
        [Test]
        public void EsValidoGetTestViewBagUsuario()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var test = usuarioControllerTest.test() as ViewResult;

            Assert.IsNotNull(test.ViewData["Usuario"]);

        }
        [Test]
        public void EsValidoPostValoracion()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var val = usuarioControllerTest.Valoracion(1);

            Assert.IsInstanceOf<JsonResult>(val);
        }
        [Test]
        public void EsValidoGetDetails()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService,
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var details = usuarioControllerTest.Details();

            Assert.IsInstanceOf<ViewResult>(details);
        }
        [Test]
        public void EsValidoGetCreate()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService,
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var Create = usuarioControllerTest.Create();

            Assert.IsInstanceOf<ViewResult>(Create);
        }
        [Test]
        public void EsValidoGetAddProducto()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService,                 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var AddProducto = usuarioControllerTest.AddProducto();

            Assert.IsInstanceOf<ViewResult>(AddProducto);
        }
        [Test]
        public void EsValidoGetProduc()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var Produc = usuarioControllerTest.Produc(1);

            Assert.IsInstanceOf<ViewResult>(Produc);
        }
        [Test]
        public void EsValidoGetServ()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var serv = usuarioControllerTest.serv(1);

            Assert.IsInstanceOf<ViewResult>(serv);
        }
        [Test]
        public void EsValidoGetServViewBagserv()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var serv = usuarioControllerTest.serv(1) as ViewResult;
            Assert.IsNull(serv.ViewData["serv"]);
        }
        [Test]
        public void EsValidoGetSearch()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var search = usuarioControllerTest.search();
            Assert.IsInstanceOf<ViewResult>(search);
        }
        [Test]
        public void EsValidoGetSearchViewBagproductos()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var search = usuarioControllerTest.search() as ViewResult;

            Assert.IsNotNull(search.ViewData["productos"]); 
        }
        [Test]
        public void EsValidoGetSearchViewBagcategoria()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var search = usuarioControllerTest.search() as ViewResult;
             
            Assert.IsNotNull(search.ViewData["categoria"]);
        }
        [Test]
        public void EsValidoGetSearchViewBagservicios()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var search = usuarioControllerTest.search() as ViewResult;
            Assert.IsNotNull(search.ViewData["servicios"]);
        }
        [Test]
        public void EsValidoPostSearch()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var search = usuarioControllerTest.Search(new Search());

            Assert.IsInstanceOf<ViewResult>(search);
        }
        [Test]
        public void EsValidoPostSearchViewBagproductos()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var search = usuarioControllerTest.Search(new Search()) as ViewResult;
            Assert.IsNotNull(search.ViewData["productos"]);
        }
        [Test]
        public void EsValidoPostSearchViewBagcategoria()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var search = usuarioControllerTest.Search(new Search()) as ViewResult;
            Assert.IsNotNull(search.ViewData["categoria"]);
        }
        [Test]
        public void EsValidoPostSearchViewBagservicios()
        {
            var WebContext = new WebeOContext();
            var httpContext = new HttpContextAccessor();
            var UsuarioService = new UsuarioService(WebContext);
            var ISessionService = new SessionService();
            var IAuthService = new AuthService(WebContext, ISessionService, httpContext);
            var IProductoService = new ProductoService(WebContext);
            var IServicioService = new ServicioService(WebContext);
            var ICategoriaService = new CategoriaService(WebContext);
            var ICloudinaryService = new CloudinaryService();
            var IImagenService = new ImagenService(WebContext, ICloudinaryService);            
            var usuarioControllerTest = new UsuarioController(IAuthService, ISessionService, IImagenService, 
                IProductoService, IServicioService, UsuarioService, ICategoriaService);
            var search = usuarioControllerTest.Search(new Search()) as ViewResult;
            Assert.IsNotNull(search.ViewData["servicios"]);
        }
    }
}
