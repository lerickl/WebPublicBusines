using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Controllers;
using WebApplication1.DataDb;
using WebApplication1.Models.viewModels;
using WebApplication1.Servicios.Interfaces;

namespace TestProject1.PruebasIntegracion
{
    [TestFixture]
    internal class EmpresaControllerTest
    {
        [Test]
        public void GetindexIsOk()
        {

            Empresa Empr = new Empresa()
            {
                NombreComercial = "Test",
                Email = "test@test.com",
                Contraseña = "123123",
                Direccion = "test",
                Telefono = "123123123",

            };
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            IAuthServiceMock.Setup(e => e.GetLogedEmpr()).Returns(Empr);
            IProductoServiceMock.Setup(e => e.GetAllProducts()).Returns(new List<Producto>());
            IServiceServiceMock.Setup(e => e.GetAllServicio()).Returns(new List<Servicio>());
            ICategoriaServiceMock.Setup(e => e.GetAllCategoria()).Returns(new List<Categoria>());
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object,
                ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object,
                IImagenServiceMock.Object, ICategoriaServiceMock.Object);

            var result = empresa.Index() as ViewResult;
            var productos = result.ViewData["productos"];
            var servicios = result.ViewData["servicios"];
            var categoria = result.ViewData["categoria"];
            Assert.AreEqual(productos, new List<Producto>());
            Assert.AreEqual(servicios, new List<Servicio>());
            Assert.AreEqual(categoria, new List<Categoria>());



        }
        [Test]
        public void GetProfileIsOk()
        {
         
            Empresa Empr = new Empresa()
            {
                NombreComercial = "Test",
                Email = "test@test.com",
                Contraseña = "123123",
                Direccion = "test",
                Telefono = "123123123",

            };
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock= new Mock<ICategoriaService>();
            IAuthServiceMock.Setup(e => e.GetLogedEmpr()).Returns(Empr);

            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object,
                ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object, 
                IImagenServiceMock.Object, ICategoriaServiceMock.Object);
         
            var result = empresa.Profile() as ViewResult ;
            var temp = result.ViewData["empresa"];
            Assert.AreEqual(temp, Empr);
         

        }
        [Test]
        public void GetProfileviewIsOk()
        {
           
            Empresa Empr = new Empresa()
            {
                NombreComercial = "Test",
                Email = "test@test.com",
                Contraseña = "123123",
                Direccion = "test",
                Telefono = "123123123",

            };

            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();

            IAuthServiceMock.Setup(e => e.GetLogedEmpr()).Returns(Empr);

            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object,
                ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object,
                IImagenServiceMock.Object, ICategoriaServiceMock.Object);
     
            var result = empresa.Profile();
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void PostProfileIsOk()
        {

            Empresa Empr = new Empresa()
            {
                NombreComercial = "Test",
                Email = "test@test.com",
                Contraseña = "123123",
                Direccion = "test",
                Telefono = "123123123",

            };
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var EmpresaViewModel = new EmpresaViewModel()
            {
                NombreComercial = "",
                Email = "EmpresaTest@test.com",
                Password = "123123",
                Direccion = "test",
                Telefono = "123123123",
           
                
            };
            IAuthServiceMock.Setup(e => e.GetLogedEmpr()).Returns(Empr);
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object, 
                ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object, IImagenServiceMock.Object,
                ICategoriaServiceMock.Object);
         
            var result = empresa.Profile(EmpresaViewModel);
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void GetCreateIsOk()
        {
            
            Empresa Empr = new Empresa()
            {
                NombreComercial = "Test",
                Email = "test@test.com",
                Contraseña = "123123",
                Direccion = "test",
                Telefono = "123123123",

            };


            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            IAuthServiceMock.Setup(e => e.GetLogedEmpr()).Returns(Empr);

            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object,
                ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object, 
                IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            
            var create = new List<Usuario>();
            var result = empresa.Create();
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void PostCreateIsOk() 
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();

          
            Empresa Empr = new Empresa()
            {
                NombreComercial = "Test",
                Email = "test@test.com",
                Contraseña = "123123",
                Direccion = "test",
                Telefono = "123123123",

            };

            IIEmpresaServiceMock.Setup(e => e.addEmpresa(Empr));
            
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object,
                ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object,
                IImagenServiceMock.Object, ICategoriaServiceMock.Object);

            var result = empresa.Create(Empr);
            Assert.IsInstanceOf<RedirectToActionResult>(result);

        }
        [Test]
        public void GetProductosIsOk()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var empr = new Empresa()
            {
                NombreComercial = "Test",
                Email = "test@test.com",
                Contraseña = "123123",
                Direccion = "test",
                Telefono = "123123123",

            };
            empr.EmpresaId = 1;
            IAuthServiceMock.Setup(e => e.GetLogedEmpr()).Returns(empr);
            IProductoServiceMock.Setup(e => e.GetProductoByID(empr.EmpresaId)).Returns(new List<Producto>());
            ICategoriaServiceMock.Setup(e => e.GetAllCategoria()).Returns(new List<Categoria>());
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object,
                IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object, 
                IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
          
            var result = empresa.Productos() ;
            Assert.IsInstanceOf<ViewResult>(result);

        }
       
        [Test]
        public void GetServiciosIsOk()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var empr = new Empresa()
            {
                NombreComercial = "Test",
                Email = "test@test.com",
                Contraseña = "123123",
                Direccion = "test",
                Telefono = "123123123",

            };
            empr.EmpresaId = 1;
            IAuthServiceMock.Setup(e => e.GetLogedEmpr()).Returns(empr);
            IServiceServiceMock.Setup(e => e.GetAllServicioListById(empr.EmpresaId)).Returns(new List<Servicio>());
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object,
                ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object, 
                IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = empresa.Servicios() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void GetAddServicioIsOk()
        {
            var empr = new Empresa()
            {
                NombreComercial = "Test",
                Email = "test@test.com",
                Contraseña = "123123",
                Direccion = "test",
                Telefono = "123123123",

            };

            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            IAuthServiceMock.Setup(e => e.GetLogedEmpr()).Returns(empr);
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object,
                ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object,
                IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = empresa.AddServicio();
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void PostAddServicioIsOk()
        {
            var empr = new Empresa()
            {
                NombreComercial = "Test",
                Email = "test@test.com",
                Contraseña = "123123",
                Direccion = "test",
                Telefono = "123123123",

            };
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            IAuthServiceMock.Setup(e => e.GetLogedEmpr()).Returns(empr);
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object,
                ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object,
                IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var addServic = new ServicioViewModel() {
                Nombre = "Test",
                Descripcion = "Test",
                Precio = "1",             
                CategoriaId = 1,
                TipoServicio = "Test"
            };
            var result = empresa.AddServicio(addServic);
            Assert.IsInstanceOf<RedirectToActionResult>(result);

        }
        [Test]
        public void GetAddProductoIsOk()
        {
            var empr = new Empresa()
            {
                NombreComercial = "Test",
                Email = "test@test.com",
                Contraseña = "123123",
                Direccion = "test",
                Telefono = "123123123",

            };
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            IAuthServiceMock.Setup(e => e.GetLogedEmpr()).Returns(empr);
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object,
                IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object, 
                IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = empresa.AddProducto();
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void GetdashboardIsOk()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, 
                IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object,
                IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = empresa.dashboard() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void GetEditPIsOk()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();

            IServiceServiceMock.Setup(e=>e.GetServicioByID(1)).Returns(new Servicio());
            ICategoriaServiceMock.Setup(e => e.GetAllCategoria()).Returns(new List<Categoria>());
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object,
                IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object,
                IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = empresa.EditP(1) as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void PostEditPIsOk()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();

            IProductoServiceMock.Setup(e => e.GetProductByIdP(1)).Returns(new Producto());
            ICategoriaServiceMock.Setup(e => e.GetAllCategoria()).Returns(new List<Categoria>());
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object,
                IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object,
                IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var Produc = new ProductoViewModel() {
                Nombre = "Test",
                Descripcion = "Test",
                Precio = "1",
                Categoria = 1,
                imgperfilProducto = null,
                EditImg="false"
                
            };
            var result = empresa.EditP(Produc);
            Assert.IsInstanceOf<RedirectToActionResult>(result);

        }
        [Test]
        public void PostEditPIsOkConImg()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();

            IProductoServiceMock.Setup(e => e.GetProductByIdP(1)).Returns(new Producto());
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object,
                IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object,
                IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var Produc = new ProductoViewModel()
            {
                Nombre = "Test",
                Descripcion = "Test",
                Precio = "1",
                Categoria = 1,
                imgperfilProducto = null,
                EditImg = "true"

            };
            var result = empresa.EditP(Produc);
            Assert.IsInstanceOf<RedirectToActionResult>(result);

        }
        [Test]
        public void PostEditPIsOkProductNull()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();

            IProductoServiceMock.Setup(e => e.GetProductByIdP(1)).Returns(new Producto());
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object,
                IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object,
                IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var Produc = new ProductoViewModel();
          
            var result = empresa.EditP(Produc);
            Assert.IsInstanceOf<RedirectToActionResult>(result);

        }
        [Test]
        public void GetRemoveProduct() {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var empr = new Empresa() {
                EmpresaId = 1,
                NombreComercial = "Test",
                Direccion = "Test",
                Telefono = "Test",
                Email = ""
            };
            var prod = new Producto() {
                ProductoId = 1,
                Nombre = "Test",
                Descripcion = "Test",
                Precio = "1",
                EmpresaId = 1,
                CategoriaId = 1
            };
            IAuthServiceMock.Setup(e => e.GetLogedEmpr()).Returns(empr);
            IProductoServiceMock.Setup(e => e.GetProductByIdP(1)).Returns(new Producto());
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object,
                IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object,
                IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var Produc = new ProductoViewModel();

            var result = empresa.RemoveP(1);
            Assert.IsInstanceOf<RedirectToActionResult>(result);
        }
        [Test]
        public void GetEditSIsOk()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();

            IProductoServiceMock.Setup(e => e.GetProductByIdP(1)).Returns(new Producto());
            ICategoriaServiceMock.Setup(e => e.GetAllCategoria()).Returns(new List<Categoria>());            
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object,
                IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object,
                IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = empresa.EditS(1) as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void PostEditSIsOk()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            IServiceServiceMock.Setup(e => e.GetServicioByID(1)).Returns(new Servicio());
            ICategoriaServiceMock.Setup(e => e.GetAllCategoria()).Returns(new List<Categoria>());
            var servic = new ServicioViewModel() {
                ServicioId = 1,
                Nombre = "Test",
                Descripcion = "Test",
                Precio = "1",
                CategoriaId = 1,
                imgperfilServicio = null,
                EditImg = "false"
            };
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object,
                IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object,
                IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);

            var result = empresa.EditS(servic);
            Assert.IsInstanceOf<RedirectToActionResult>(result);

        }
        [Test]
        public void PostEditSIsOkConImagen()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            IServiceServiceMock.Setup(e => e.GetServicioByID(1)).Returns(new Servicio());
            ICategoriaServiceMock.Setup(e => e.GetAllCategoria()).Returns(new List<Categoria>());
            var servic = new ServicioViewModel()
            {
                ServicioId = 1,
                Nombre = "Test",
                Descripcion = "Test",
                Precio = "1",
                CategoriaId = 1,
                imgperfilServicio = null,
                EditImg = "true"
            };
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object,
                IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object,
                IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);

            var result = empresa.EditS(servic);
            Assert.IsInstanceOf<RedirectToActionResult>(result);

        }
        [Test]
        public void PostEditServicenull()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            IServiceServiceMock.Setup(e => e.GetServicioByID(1)).Returns(new Servicio());
            ICategoriaServiceMock.Setup(e => e.GetAllCategoria()).Returns(new List<Categoria>());
            var servic = new ServicioViewModel() ;
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object,
                IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object,
                IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);

            var result = empresa.EditS(servic);
            Assert.IsInstanceOf<RedirectToActionResult>(result);

        }
        [Test]
        public void GetRemoveService()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var empr = new Empresa()
            {
                EmpresaId = 1,
                NombreComercial = "Test",
                Direccion = "Test",
                Telefono = "Test",
                Email = "Test@upn.pe"
            };
            var serv = new Servicio() 
            {
                ServicioId = 1,
                Nombre = "Test",
                Descripcion = "Test",
                Precio = "1",
                CategoriaId = 1,
                EmpresaId = 1
            };      
            IAuthServiceMock.Setup(e => e.GetLogedEmpr()).Returns(empr);
            IServiceServiceMock.Setup(e => e.GetServicioByID(1)).Returns(serv);
            
            var servic = new ServicioViewModel();
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object,
                IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object,
                IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);

            var result = empresa.RemoveS(1);
            Assert.IsInstanceOf<RedirectToActionResult>(result);

        }

    }
}
