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
    public class WaitingForAsyncUnitTest
    {
        [Test]
        public void WaitingForAsyncData()
        {
            using var ctx = new Bunit.TestContext();
            ctx.Services.AddSingleton<AuthService>(new AuthService());

            IRenderedFragment component = ctx.RenderComponent<FetchData>();

            component.WaitForState(() => component.Find(".date").TextContent == "Date");

            Assert.That(component.Find($".table").NodeName, Is.EqualTo("Table"));
        }
    }
}
