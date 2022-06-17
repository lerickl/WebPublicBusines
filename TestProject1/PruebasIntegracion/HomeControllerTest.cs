using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    internal class HomeControllerTest
    {
        [Test]
        public void GetIndexIsOk()
        {

            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IEmpresaServiceMock = new Mock<IEmpresaService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var IHttpContextAccessor = new Mock<IHttpContextAccessor>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var IValidacionesServiceMock = new Mock<IValidacionesService>();
            var IProductServiceMock = new Mock<IProductoService>();
            var IServicioServiceMock = new Mock<IServicioService>();

            var home = new HomeController(IHttpContextAccessor.Object, IUsuarioServiceMock.Object, IEmpresaServiceMock.Object,
                ISessionServiceMock.Object, IAuthServiceMock.Object, IValidacionesServiceMock.Object, IProductServiceMock.Object,
                IServicioServiceMock.Object, ICategoriaServiceMock.Object);


            Assert.IsNull(home.ViewBag.UserLogged);


        }
        [Test]
        public void GetRegisterIsOk()
        {
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IEmpresaServiceMock = new Mock<IEmpresaService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var IHttpContextAccessor = new Mock<IHttpContextAccessor>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var IValidacionesServiceMock = new Mock<IValidacionesService>();
            var IProductServiceMock = new Mock<IProductoService>();
            var IServicioServiceMock = new Mock<IServicioService>();

            var home = new HomeController(IHttpContextAccessor.Object, IUsuarioServiceMock.Object, IEmpresaServiceMock.Object,
                ISessionServiceMock.Object, IAuthServiceMock.Object, IValidacionesServiceMock.Object, IProductServiceMock.Object,
                IServicioServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = home.Register() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void GetLoginIsOk()
        {
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IEmpresaServiceMock = new Mock<IEmpresaService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var IHttpContextAccessor = new Mock<IHttpContextAccessor>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var IValidacionesServiceMock = new Mock<IValidacionesService>();
            var IProductServiceMock = new Mock<IProductoService>();
            var IServicioServiceMock = new Mock<IServicioService>();

            var home = new HomeController(IHttpContextAccessor.Object, IUsuarioServiceMock.Object, IEmpresaServiceMock.Object,
                ISessionServiceMock.Object, IAuthServiceMock.Object, IValidacionesServiceMock.Object, IProductServiceMock.Object,
                IServicioServiceMock.Object, ICategoriaServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = home.Login() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
        [Test]
        public void GetPrivacyIsOk()
        {
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IEmpresaServiceMock = new Mock<IEmpresaService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var IHttpContextAccessor = new Mock<IHttpContextAccessor>();
            var ICategoriaServiceMock = new Mock<ICategoriaService>();
            var IValidacionesServiceMock = new Mock<IValidacionesService>();
            var IProductServiceMock = new Mock<IProductoService>();
            var IServicioServiceMock = new Mock<IServicioService>();

            var home = new HomeController(IHttpContextAccessor.Object, IUsuarioServiceMock.Object, IEmpresaServiceMock.Object,
                ISessionServiceMock.Object, IAuthServiceMock.Object, IValidacionesServiceMock.Object, IProductServiceMock.Object,
                IServicioServiceMock.Object, ICategoriaServiceMock.Object); 
            var inmuebles = new List<Usuario>();
            var result = home.Privacy() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
    }
}
