namespace TestNinja.UnitTest
{
    [TestFixture]
    public class MathUnitTest
    {
        private Shared.MathClass _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Shared.MathClass();
        }

        [Test]
        public void Add_WhenCalled_ReturnSummation()
        {
            var result = _math.Add(5, 7);
            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        [TestCase(5, 7, 7)]
        [TestCase(6, 7, 7)]
        public void Max_GreatestArgument_ReturnGreatestArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}
