using System;
using NUnit.Framework;
using CSharpCalculator;

namespace UnitTestProjectForCalc.NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.None)]
    public class Negative_N: NUTestClass
    {
        Calculator calc = new Calculator();

        [OneTimeTearDown]
        public override void AfterSuite()
        {
            Console.WriteLine("Testing of Negative has been finished!");
        }

        [OneTimeSetUp]
        public override void BeforeSuite()
        {
            Console.WriteLine("Testing of Negative has been started!");
        }

        [Test]
        [TestCase("0.1")]
        [TestCase(0)]
        [TestCase(-0.1)]
        [Description("Check is input number Negative")]
        public void CheckisNegative(object number)
        {
            bool expResult = false;
            string assertText = null;          //Arrange
            if (Double.Parse(number.ToString()) < 0)
            {
                expResult = true;
                assertText = "as not negative";
            }
            else
            {
                expResult = false;
                assertText = "as negative";
            }

            bool actResult = calc.isNegative(Double.Parse(number.ToString()));                          //Action

            Assert.AreEqual(expResult, actResult,$"{number} identifyed {assertText}");                      //Assert 
        }
    }
}
