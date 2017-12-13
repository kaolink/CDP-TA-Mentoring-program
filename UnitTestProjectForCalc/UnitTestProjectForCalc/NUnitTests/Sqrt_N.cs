using System;
using NUnit.Framework;
using CSharpCalculator;

namespace UnitTestProjectForCalc.NUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class Sqrt_N : NUTestClass
    {
        Calculator calc = new Calculator();

        [OneTimeTearDown]
        public override void AfterSuite()
        {
            Console.WriteLine("Testing of Sqrt has been finished!");
        }

        [OneTimeSetUp]
        public override void BeforeSuite()
        {
            Console.WriteLine("Testing of Sqrt has been started!");
        }

        [Test]
        [TestCase("-0.2")]
        [TestCase(1.1)]
        [TestCase(0.1)]
        [TestCase(0)]
        [TestCase(25)]
        [Description("Check that method returns square root of input value")]
        public void CheckSqrt(object number)
        {
            double actResult = calc.Sqrt(Double.Parse(number.ToString()));
            double expResult = Math.Sqrt(Double.Parse(number.ToString()));

            Assert.AreEqual(expResult, actResult, $"Square root from '{number}' equals '{expResult}', but was '{actResult}'");
        }
    }
}
