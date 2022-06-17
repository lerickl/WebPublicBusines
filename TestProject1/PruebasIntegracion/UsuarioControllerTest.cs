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

namespace TestProject1.PruebasIntegracion
{
    [TestFixture]
    internal class UsuarioControllerTest
    {
        [Test]
        public void GetRegisterIsOk()
        {
               ;
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IImamgenServiceMock = new Mock<IImagenService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServicioServiceMock= new Mock<IServicioService>();
            var iUsuarioServiceMock = new Mock<IUsuarioService>();
            var iCategoriaServiceMock = new Mock<ICategoriaService>();


            var home = new UsuarioController(IAuthServiceMock.Object, ISessionServiceMock.Object, IImamgenServiceMock.Object, IProductoServiceMock.Object, IServicioServiceMock.Object, iUsuarioServiceMock.Object, iCategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = home.Index() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void GetdashboardIsOk()
        {
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IImamgenServiceMock = new Mock<IImagenService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServicioServiceMock = new Mock<IServicioService>();
            var iUsuarioServiceMock = new Mock<IUsuarioService>();
            var iCategoriaServiceMock = new Mock<ICategoriaService>();


            var home = new UsuarioController(IAuthServiceMock.Object, ISessionServiceMock.Object, IImamgenServiceMock.Object, IProductoServiceMock.Object, IServicioServiceMock.Object, iUsuarioServiceMock.Object, iCategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = home.dashboard() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void GetProductosIsOk()
        {
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IImamgenServiceMock = new Mock<IImagenService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServicioServiceMock = new Mock<IServicioService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var iUsuarioServiceMock = new Mock<IUsuarioService>();
            var home = new UsuarioController(IAuthServiceMock.Object, ISessionServiceMock.Object,
                IImamgenServiceMock.Object, IProductoServiceMock.Object, IServicioServiceMock.Object,
                iUsuarioServiceMock.Object, ICategoriaServiceMock.Object); 
            var inmuebles = new List<Usuario>();
            var result = home.Productos() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void GetServiciosIsOk()
        {
            
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IImamgenServiceMock = new Mock<IImagenService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServicioServiceMock = new Mock<IServicioService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var iUsuarioServiceMock = new Mock<IUsuarioService>();
            var home = new UsuarioController(IAuthServiceMock.Object, ISessionServiceMock.Object,
                IImamgenServiceMock.Object, IProductoServiceMock.Object, IServicioServiceMock.Object, 
                iUsuarioServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = home.Servicios() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void GetProfileIsOk()
        {
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IImamgenServiceMock = new Mock<IImagenService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServicioServiceMock = new Mock<IServicioService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var iUsuarioServiceMock = new Mock<IUsuarioService>();
            var home = new UsuarioController(IAuthServiceMock.Object, ISessionServiceMock.Object,
                IImamgenServiceMock.Object, IProductoServiceMock.Object, IServicioServiceMock.Object,
                iUsuarioServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = home.Profile() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void GetDetailsIsOk()
        {
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IImamgenServiceMock = new Mock<IImagenService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServicioServiceMock = new Mock<IServicioService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var iUsuarioServiceMock = new Mock<IUsuarioService>();
            var home = new UsuarioController(IAuthServiceMock.Object, ISessionServiceMock.Object,
                IImamgenServiceMock.Object, IProductoServiceMock.Object, IServicioServiceMock.Object,
                iUsuarioServiceMock.Object, ICategoriaServiceMock.Object); var inmuebles = new List<Usuario>();
            var result = home.Details() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void GetCreateIsOk()
        {
            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IImamgenServiceMock = new Mock<IImagenService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServicioServiceMock = new Mock<IServicioService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var iUsuarioServiceMock = new Mock<IUsuarioService>();
            var home = new UsuarioController(IAuthServiceMock.Object, ISessionServiceMock.Object,
                IImamgenServiceMock.Object, IProductoServiceMock.Object, IServicioServiceMock.Object,
                iUsuarioServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = home.Create() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void GetAddProductoIsOk()
        {

            var IAuthServiceMock = new Mock<IAuthService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IImamgenServiceMock = new Mock<IImagenService>();
            var IProductoServiceMock = new Mock<IProductoService>();
            var IServicioServiceMock = new Mock<IServicioService>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var iUsuarioServiceMock = new Mock<IUsuarioService>();
            var home = new UsuarioController(IAuthServiceMock.Object, ISessionServiceMock.Object,
                IImamgenServiceMock.Object, IProductoServiceMock.Object, IServicioServiceMock.Object,
                iUsuarioServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = home.AddProducto() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
     
    }
}
