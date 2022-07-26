using Bunit;
using TestNinja.Client.Pages;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class PassingParameterUnitTest
    {
        [Test]
        public void SuccessfullyPassingParameter()
        {
            using var ctx = new Bunit.TestContext();
            Action onButtonClickHandler = () => { };

            IRenderedFragment component = ctx.RenderComponent<Counter>(parameter =>
                parameter
                .Add(c => c.DefaultCount, 15)
               /* .Add(c => c.IncrementCount, onButtonClickHandler)*/
            );

            /*Assert.Equals("Click me", component.Find($".btn").TextContent);*/
            Assert.That(component.Find($".btn").TextContent, Is.EqualTo("Click me"));
        }
    }
}
