using Bunit;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Client.Pages;
using TestNinja.Server.Services.AuthService;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class PassingServiceUnitTest
    {
        [Test]
        public void PassingServicesAndInput()
        {
            using var ctx = new Bunit.TestContext();
            ctx.Services.AddSingleton < AuthService > (new AuthService());

            IRenderedFragment component = ctx.RenderComponent<Counter>();
            Assert.That(component.Find($".btn").TextContent,Is.EqualTo("CLick me").IgnoreCase);
        }

    }
}
