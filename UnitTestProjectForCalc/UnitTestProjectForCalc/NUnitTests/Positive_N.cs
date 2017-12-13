using System;
using NUnit.Framework;
using CSharpCalculator;

namespace UnitTestProjectForCalc.NUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class Positive_N : NUTestClass
    {
        Calculator calc = new Calculator();

        [OneTimeTearDown]
        public override void AfterSuite()
        {
            Console.WriteLine("Testing of Positive has been finished!");
        }

        [OneTimeSetUp]
        public override void BeforeSuite()
        {
            Console.WriteLine("Testing of Positive has been started!");
        }

        [Test]
        [TestCase("0.1")]
        [TestCase(0)]
        [TestCase(-0.1)]
        [Description("Check is input number Negative")]
        public void CheckisNegative(object number)
        {
            bool expResult = false;                                  //Arrange
            string assertText = null;
            if (Double.Parse(number.ToString()) > 0)
            {
                expResult = true;
                assertText = "as not positive";
            }
            else
            {
                expResult = false;
                assertText = "as positive";
            }

            bool actResult = calc.isPositive(Double.Parse(number.ToString()));              //Action

            Assert.AreEqual(expResult, actResult, $"{number} identifyed {assertText}");                 //Assert 
        }
    }
}
