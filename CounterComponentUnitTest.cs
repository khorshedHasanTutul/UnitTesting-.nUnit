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
   
    public class CounterComponentUnitTest
    {
        [Test]
        public void NoMethodName_CaptureCount_MatchesCount()
        {
            using var ctx = new Bunit.TestContext();
            IRenderedFragment component = ctx.RenderComponent<Counter>();
            IElement button = component.Find("button");
            button.Click();

            IElement paragraph = component.Find("p");
            paragraph.MarkupMatches("<p role=status>Current count: <span class=\"counterValue\">1</span></p>");

        }
    }
}
