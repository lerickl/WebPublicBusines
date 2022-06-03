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
using WebApplication1.Servicios.Interfaces;

namespace TestProject1.UnitTest
{
    [TestFixture]
    internal class EmpresaControllerTest
    {
        [Test]
        public void GetRegisterIsOk()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock= new Mock<ICategoriaService>();


            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
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

            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = empresa.Profile() as ViewResult;
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

            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = empresa.Create() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
       
        public void GetProductosIsOk()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = empresa.Productos() as ViewResult;
            Assert.IsNotInstanceOf<ViewResult>(result);

        }
      
        public void GetServiciosIsOk()
        {
            var IIEmpresaServiceMock = new Mock<IEmpresaService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServiceServiceMock = new Mock<IServicioService>();
            var IImagenServiceMock = new Mock<IImagenService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
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
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
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
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
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
            var empresa = new EmpresaController(IIEmpresaServiceMock.Object, IAuthServiceMock.Object, ISessionServiceMock.Object, IProductoServiceMock.Object, IServiceServiceMock.Object, IImagenServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = empresa.dashboard() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
         
    }
}
