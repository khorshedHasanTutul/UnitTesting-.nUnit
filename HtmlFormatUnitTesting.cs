using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class HtmlFormatUnitTesting
    {
        [SetUp]
        public void SetUp()
        {

        }
        [Test]  
        public void htmlFormat_BoldText_ReturnString()
        {
            var htmlFormat = new Shared.HtmlFormatter();
            var result = htmlFormat.htmlFormat("abc");
            /* Assert.That(result, Is.EqualTo("<strong>abc</strong>")); */
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));
        }
    }
}
