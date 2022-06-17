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
        public void GetiNDEXIsOk()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock= new Mock<ICategoriaService>();           
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object,
                ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object, 
                IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = empresa.Index() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void GetProfileIsOk()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object,
                ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object,
                IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = empresa.Profile() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void PostProfileIsOk()
        {
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
            IAuthServiceMock.Setup(e => e.GetLogedEmpr()).Returns(new Empresa());
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object, 
                ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object, IImagenServiceMock.Object,
                ICategoriaServiceMock.Object);
         
            var result = empresa.Profile(EmpresaViewModel);
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void GetCreateIsOk()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();

            IAuthServiceMock.Setup(e => e.GetLogedEmpr()).Returns(new Empresa());
            Empresa Empr = new Empresa() 
            {
                NombreComercial = "Test",
                Email = "test@test.com",
                Contraseña = "123123",
                Direccion = "test",
                Telefono = "123123123",
            
            };
         
            
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
            var empr = new Empresa();
            empr.EmpresaId = 1;
            IAuthServiceMock.Setup(e => e.GetLogedEmpr()).Returns(empr);
            IProductoServiceMock.Setup(e => e.GetProductoByID(empr.EmpresaId)).Returns(new List<Producto>());
            ICategoriaServiceMock.Setup(e => e.GetAllCategoria()).Returns(new List<Categoria>());
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object,
                IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object, 
                IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = empresa.Productos() as ViewResult;
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
            var empr = new Empresa();
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


            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object,
                ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object,
                IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = empresa.AddServicio() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void GetAddProductoIsOk()
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
            var result = empresa.AddProducto() as ViewResult;
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
         
    }
}
