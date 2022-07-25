using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using TestNinja.Server.Controllers;
using TestNinja.Server.Services.AuthService;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class AuthenticationUnitTesting
    {

        [Test]
        public void Register_SubmitEmptyForm_ReturnFalse()
        {
            var register = new Mock<IAuthService>();
            var result = register.Object.Register("", "");
            Assert.That(result, Is.False);
        }

        [Test]
        public void Register_SubmitValueForm_ReturnTrue()
        {
            var register = new Mock<IAuthService>();
            register.Setup(rg=>rg.Register("hello@gmail.com","123456")).Returns(true);
            var obj =register.Object;
            var result = obj.Register("hello@gmail.com", "123456");
            Assert.That(result, Is.True);
        }

        [Test]
        public void Login_SubmitEmptyValue_ReturnFalse()
        {
            var login = new AuthService();
            var result = login.Login("","");
            Assert.That(result, Is.False);
        }

        [Test]
        public void Login_SubmitLoginValue_ReturnTrue()
        {
            var login = new AuthService();
            var result = login.Login("tutul", "123456");
            Assert.That(result, Is.True); 
        }

        [Test]
        [TestCase("mehedi","123456")]
        [TestCase("tutul","")]
        public void Login_SubmitWrongValue_ReturnFalse(string userName, string passWord)
        {
            var login = new AuthService();
            var result = login.Login(userName, passWord);
            Assert.That(result, Is.False);
        }

        [Test]
        public void Login_TestResponseController_ReturnOk()
        {
            
            var login = new Mock<IAuthService>();
            login.Setup(l => l.Register("tutul", "123456")).Returns(true);

            var controller = new AccountController(login.Object);

            var result = controller.Register(new Server.DTOs.UserDto { UserName = "tutul", Password = "123456" });

            Assert.That(result, Is.True);
            
        }

    }
}
