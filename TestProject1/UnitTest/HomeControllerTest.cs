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

namespace TestProject1.UnitTest
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
            var ICategoriaServiceMock = new Mock<ICategoriaEmpresa>();
            var IValidacionesServiceMock = new Mock<IValidacionesService>();

            var home = new HomeController(IHttpContextAccessor.Object, IUsuarioServiceMock.Object, IEmpresaServiceMock.Object, ISessionServiceMock.Object, IAuthServiceMock.Object, ICategoriaServiceMock.Object, IValidacionesServiceMock.Object);

            //var inmuebles = IInmuebleServiceMock.Setup(x=>x.GetInmubles()).Returns(new List<Inmueble>());
            var inmuebles = new List<Usuario>();
            //var Imagenes = new List<Imagen>();
            //var tipoinmueble = new List<InmuebleTipo>();
            //var ciudad = new List<Ciudades>();
            var result = home.Index() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

            //Assert.IsNull(result.ViewBag.UserLogged);
            //Assert.AreEqual(result.ViewBag.Inmuebles, inmuebles);
            //Assert.AreEqual(result.ViewBag.Imagenes, Imagenes);
            //Assert.AreEqual(result.ViewBag.TipoInmueble, tipoinmueble);
            //Assert.AreEqual(result.ViewBag.ciudad, ciudad);

        }
        [Test]
        public void GetRegisterIsOk()
        { 
            var IUsuarioServiceMock = new Mock<IUsuarioService>();
            var IEmpresaServiceMock = new Mock<IEmpresaService>();
            var ISessionServiceMock = new Mock<ISessionService>();
            var IAuthServiceMock = new Mock<IAuthService>();
            var IHttpContextAccessor = new Mock<IHttpContextAccessor>();
            var ICategoriaServiceMock = new Mock<ICategoriaEmpresa>();
            var IValidacionesServiceMock = new Mock<IValidacionesService>();

            var home = new HomeController(IHttpContextAccessor.Object, IUsuarioServiceMock.Object, IEmpresaServiceMock.Object, ISessionServiceMock.Object, IAuthServiceMock.Object, ICategoriaServiceMock.Object, IValidacionesServiceMock.Object);
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
            var ICategoriaServiceMock = new Mock<ICategoriaEmpresa>();
            var IValidacionesServiceMock = new Mock<IValidacionesService>();

            var home = new HomeController(IHttpContextAccessor.Object, IUsuarioServiceMock.Object, IEmpresaServiceMock.Object, ISessionServiceMock.Object, IAuthServiceMock.Object, ICategoriaServiceMock.Object, IValidacionesServiceMock.Object);
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
            var ICategoriaServiceMock = new Mock<ICategoriaEmpresa>();
            var IValidacionesServiceMock = new Mock<IValidacionesService>();

            var home = new HomeController(IHttpContextAccessor.Object, IUsuarioServiceMock.Object, IEmpresaServiceMock.Object, ISessionServiceMock.Object, IAuthServiceMock.Object, ICategoriaServiceMock.Object, IValidacionesServiceMock.Object);
            var inmuebles = new List<Usuario>();
            var result = home.Privacy() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);

        }
    }
}
