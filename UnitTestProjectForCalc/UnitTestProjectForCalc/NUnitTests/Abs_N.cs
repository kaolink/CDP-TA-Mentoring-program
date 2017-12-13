using System;
using NUnit.Framework;
using CSharpCalculator;

namespace UnitTestProjectForCalc.NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.None)]
    public class Abs_N:NUTestClass
    {
        Calculator calc = new Calculator();

        [Test]
        [TestCase("-0.2")]
        [TestCase(-1.1)]      // Bug
        [TestCase(0.1)]      // Bug
        [TestCase(0)]
        [Description("Check that method returns abs value of input number")]
        public void CheckAbs(object number)
        {
            double actResult = calc.Abs(Double.Parse(number.ToString()));
            double expResult = Math.Abs(Double.Parse(number.ToString()));


            Assert.AreEqual(expResult, actResult, $"ABS of '{number}' should be '{expResult}' but was '{actResult}'");

        }

        [OneTimeSetUp]
        public override void BeforeSuite()
        {
            Console.WriteLine("Testing of Abs has been started!");
        }

        [OneTimeTearDown]
        public override void AfterSuite()
        {
            Console.WriteLine("Testing of Abs has been finished!");
        }
    }
}
