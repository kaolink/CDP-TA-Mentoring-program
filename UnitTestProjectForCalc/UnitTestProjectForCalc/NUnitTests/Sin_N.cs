using System;
using NUnit.Framework;
using CSharpCalculator;

namespace UnitTestProjectForCalc.NUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class Sin_N : NUTestClass
    {
        Calculator calc = new Calculator();

        [OneTimeTearDown]
        public override void AfterSuite()
        {
            Console.WriteLine("Testing of Sin has been finished!");
        }

        [OneTimeSetUp]
        public override void BeforeSuite()
        {
            Console.WriteLine("Testing of Sin has been started!");
        }

        [Test]
        [TestCase("0")]
        [TestCase(89.9)]
        [TestCase(90.1)]
        [TestCase(90)]
        [TestCase(-179.9)]
        [TestCase(-180)]
        [TestCase(-180.1)]
        [TestCase(360)]
        [TestCase(360.1)]
        [Description("Check that method returns Sin of input angle")]
        public void CheckSin(object angle)
        {
            double actResult = calc.Sin(angle);
            double expResult = Math.Sin((Convert.ToDouble(angle)));

            Assert.AreEqual(expResult, actResult, $"Sinus of '{angle}' is equal '{expResult}', but was '{actResult}'");
        }
    }
}
