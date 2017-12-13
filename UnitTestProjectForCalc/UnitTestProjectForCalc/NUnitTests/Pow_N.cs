using System;
using NUnit.Framework;
using CSharpCalculator;

namespace UnitTestProjectForCalc.NUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class Pow_N:NUTestClass
    {
        Calculator calc = new Calculator();

        [OneTimeTearDown]
        public override void AfterSuite()
        {
            Console.WriteLine("Testing of Pow has been finished!");
        }


        [OneTimeSetUp]
        public override void BeforeSuite()
        {
            Console.WriteLine("Testing of Pow has been started!");
        }

        [Test]
        [TestCase("5.43", "4.11")]   //String parameters
        [TestCase(5.43, 7.12)]       //Double parameters
        [TestCase(0, 5)]
        [TestCase(-0.1, 0.58)]
        [TestCase(5, 0)]
        [Description("Check that method returns result from exponentiation of first input value in other one")]
        public void CheckPow(object number, object powNumber)
        {
            double actResult = calc.Pow(number, powNumber);
            double expResult = Math.Pow(Double.Parse(number.ToString()), Double.Parse(powNumber.ToString()));

            Assert.AreEqual(expResult, actResult,$"{number}^{powNumber}={expResult}, but was {actResult}");
        }
    }
}
