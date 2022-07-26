using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Client.Pages;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public  class BlazorComponentUnitTesting
    {
        [Test]
        public void RenderSuccessfully()
        {
            using var ctx = new Bunit.TestContext();

            var component = ctx.RenderComponent<Counter>();
            Assert.IsNotNull(component);
            
        }
    }
}
