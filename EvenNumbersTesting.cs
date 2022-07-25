using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Shared;
namespace TestNinja.UnitTest
{
    [TestFixture]
    public class EvenNumbersTesting
    {
        [Test]
        public void GetEvenNumber_EvenNumbersList_ReturnEvenNumbers()
        {
            var EvenNumbers = new ArrayOfList();
            var result = EvenNumbers.GetEvenNumbers(10);
            Assert.That(result, Is.EquivalentTo(new[] { 0, 2, 4, 6, 8 }));
        }
    }
}
