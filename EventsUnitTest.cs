using AngleSharp.Dom;
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
    public class EventsUnitTest
    {
        [Test]
        public void EventWorkingSuccessfully()
        {
            using var ctx = new Bunit.TestContext();
            IRenderedFragment component = ctx.RenderComponent<Counter>();
            var counterValue = "0";

            Assert.That(counterValue, Is.EqualTo(component.Find($".counterValue").TextContent));

            counterValue = "1";
            IElement button = component.Find("button");
            button.Click();

            Assert.That(component.Find($".counterValue").TextContent, Is.EqualTo(counterValue));
        }
    }
}
