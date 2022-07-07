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
    public class UnitariasEmpresaControllerTest
    {
        [Test]
        public void IsValidIndexEmpresa() {
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
            var IEmpresaService = new EmpresaService(WebContext);
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService,
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var index = empresaControllerTest.Index();
            Assert.IsInstanceOf<ViewResult>(index);
        }
        [Test]
        public void IsValidIndexEmpresaViewBagproductos()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService, 
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var index = empresaControllerTest.Index() as ViewResult;
            Assert.IsNotNull(index.ViewData["productos"]);
        }
        [Test]
        public void IsValidIndexEmpresaViewBagservicios()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService,
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var index = empresaControllerTest.Index() as ViewResult;
            Assert.IsNotNull(index.ViewData["servicios"]);
        }
        [Test]
        public void IsValidIndexEmpresaViewBagcategoria()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService, 
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var index = empresaControllerTest.Index() as ViewResult;
            Assert.IsNotNull(index.ViewData["categoria"]);
        }
        [Test]
        public void IsValidProfileEmpresa() {
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
            var IEmpresaService = new EmpresaService(WebContext);
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService,
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var Profile = empresaControllerTest.Profile();
            Assert.IsInstanceOf<RedirectToActionResult>(Profile);
        }
        [Test]
        public void IsValidPostProfileEmpresa()
        {
            var emp = new EmpresaViewModel();
            emp.NombreComercial = "Empresa test";
            emp.Email = "Empresa@test.com";
            emp.CategoriaId = 1;
            emp.Telefono = "123123123";
            emp.Ruc = "123123123";
            emp.Direccion = "direccion test";
            emp.isperfil = "false";          

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
            var IEmpresaService = new EmpresaService(WebContext);
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService,
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var Profile = empresaControllerTest.Profile(emp);
            Assert.IsInstanceOf<RedirectToActionResult>(Profile);
        }
        [Test]
        public void IsValidGetEmpresacreate()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService,
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var Profile = empresaControllerTest.Create();
            Assert.IsInstanceOf<ViewResult>(Profile);
        }
        [Test]
        public void IsValidPostEmpresacreate()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService,
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var create = empresaControllerTest.Create(new Empresa());
            Assert.IsInstanceOf<RedirectToActionResult>(create);
        }
        [Test]
        public void IsValidGetproductos()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService, 
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var Productos = empresaControllerTest.Productos();
            Assert.IsInstanceOf<RedirectToActionResult>(Productos);
        }
        [Test]
        public void IsValidGetServicios()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService,
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var Servicios = empresaControllerTest.Servicios();
            Assert.IsInstanceOf<RedirectToActionResult>(Servicios);        
        }
        [Test]
        public void IsValidPostAddServicios()
        {
            var serv = new ServicioViewModel();
            serv.Nombre = "test";
            serv.TipoServicio = "tipo serv";
            serv.Precio = "10";
            serv.Descripcion = "descripcion test";
            serv.imgperfilServicio = null;
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
            var IEmpresaService = new EmpresaService(WebContext);
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService, 
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var AddServicio = empresaControllerTest.AddServicio(serv);
            Assert.IsInstanceOf<RedirectToActionResult>(AddServicio);

        }
        [Test]
        public void IsValidGetAddProducto()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService,
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var AddProducto = empresaControllerTest.AddProducto();
            Assert.IsInstanceOf<ViewResult>(AddProducto);
        }
        [Test]
        public void IsValidGetAddProductoViewBagcategoria()
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
            var IEmpresaService = new EmpresaService(WebContext);            
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService, 
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var AddProducto = empresaControllerTest.AddProducto() as ViewResult;
            Assert.IsNotNull(AddProducto.ViewData["categoria"]);

        }
        [Test]
        public void IsValidPostAddProducto()
        {
            var prod = new ProductoViewModel();
            prod.Nombre = "";
            prod.Categoria = 1;
            prod.Descripcion = "descripcion producto";
            prod.Precio = "123";
            prod.Marca = "test marca";
            prod.imgperfilProducto = null;
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
            var IEmpresaService = new EmpresaService(WebContext);
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService,
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var AddProducto = empresaControllerTest.AddProducto(prod);
            Assert.IsInstanceOf<RedirectToActionResult>(AddProducto);
        }
        [Test]
        public void IsValidGetDashboard()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService, 
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var dashboard = empresaControllerTest.dashboard();
            Assert.IsInstanceOf<ViewResult>(dashboard);
        }
        [Test]
        public void IsValidGetEditP()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService,
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var EditP = empresaControllerTest.EditP(1);            
            Assert.IsInstanceOf<ViewResult>(EditP);
        }
        
        [Test]
        public void IsValidPostRemoveP()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var produc = new ProductoViewModel();
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService,
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var EditP = empresaControllerTest.RemoveP(1);
            Assert.IsInstanceOf<RedirectToActionResult>(EditP);
        }
        [Test]
        public void IsValidGetEditS()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var produc = new ProductoViewModel();
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService, 
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var EditP = empresaControllerTest.EditS(1);
            Assert.IsInstanceOf<ViewResult>(EditP);

        }
        [Test]
        public void IsValidGetEditSViewBagservicio()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var produc = new ProductoViewModel();
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService, 
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var EditS = empresaControllerTest.EditS(1) as ViewResult;
            Assert.IsNull(EditS.ViewData["servicio"]);
        }
        [Test]
        public void IsValidGetEditSViewBagcategoria()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var produc = new ProductoViewModel();
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService,
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var EditS = empresaControllerTest.EditS(1) as ViewResult;
            Assert.IsNotNull(EditS.ViewData["categoria"]);

        }
        [Test]
        public void IsValidPostEditS()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var produc = new ProductoViewModel();
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService, 
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var EditS = empresaControllerTest.EditS(new ServicioViewModel());
            Assert.IsInstanceOf<RedirectToActionResult>(EditS);
        }
        [Test]
        public void IsValidGetRemoveS()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var produc = new ProductoViewModel();
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService,
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var RemoveS = empresaControllerTest.RemoveS(2);
            Assert.IsInstanceOf<RedirectToActionResult>(RemoveS);
        }
        [Test]
        public void IsValidGetProduc()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var produc = new ProductoViewModel();
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService, 
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var Produc = empresaControllerTest.Produc(2);
            Assert.IsInstanceOf<ViewResult>(Produc);
        }
        [Test]
        public void IsValidGetserv()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var produc = new ProductoViewModel();
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService, 
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var serv = empresaControllerTest.serv(2);
            Assert.IsInstanceOf<ViewResult>(serv);
        }
        [Test]
        public void IsValidGetsearch()
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
            var IEmpresaService = new EmpresaService(WebContext);
            var produc = new ProductoViewModel();
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService,
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var search = empresaControllerTest.search();
            Assert.IsInstanceOf<ViewResult>(search);
        }
        [Test]
        public void IsValidPostsearch()
        {
            var busqueda = new Search();
            busqueda.busqueda = "telefonos";
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
            var IEmpresaService = new EmpresaService(WebContext);
            var produc = new ProductoViewModel();
            var empresaControllerTest = new EmpresaController(IEmpresaService, IAuthService, 
                ISessionService, IProductoService, IServicioService, IImagenService, ICategoriaService);
            var search = empresaControllerTest.Search(busqueda);
            Assert.IsInstanceOf<ViewResult>(search);
        }
    }
}
