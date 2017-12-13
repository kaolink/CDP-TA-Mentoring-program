using System;
using NUnit.Framework;
using CSharpCalculator;

namespace UnitTestProjectForCalc.NUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class Cos_N:NUTestClass
    {
        Calculator calc = new Calculator();

        [OneTimeTearDown]
        public override void AfterSuite()
        {
            Console.WriteLine("Testing of Cos has been finished!");
        }

        [OneTimeSetUp]
        public override void BeforeSuite()
        {
            Console.WriteLine("Testing of Cos has been started!");
        }

        [Test]
        [TestCase("0")]
        [TestCase(89.9)]
        [TestCase(90.1)]
        [TestCase(90)]
        [TestCase(-89.9)]
        [TestCase(-90)]
        [TestCase(-90.1)]
        [TestCase(360)]
        [TestCase(360.1)]
        [Description("Check that method returns Cos of input angle")]

        public void CheckCos(object angle)
        {
            double actResult = calc.Cos(Double.Parse(angle.ToString()));
            double expResult = Math.Cos(Double.Parse(angle.ToString()));

            Assert.AreEqual(expResult, actResult,$"Cosinus of '{angle}' equals '{expResult}', but was '{actResult}'");
        }
    }
}
