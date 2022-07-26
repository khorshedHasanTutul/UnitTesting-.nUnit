using Bunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Client.Pages;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class RendersComponent
    {
        [Test]
        public void RendersSuccessfully()
        {
            using var ctx = new Bunit.TestContext();
            IRenderedFragment component = ctx.RenderComponent<Counter>();
            Assert.That(component.Find($".btn").TextContent, Is.EqualTo("Click me"));
        }
    }
}
