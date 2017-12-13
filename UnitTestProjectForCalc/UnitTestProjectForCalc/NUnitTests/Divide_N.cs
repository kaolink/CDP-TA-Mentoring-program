using System;
using NUnit.Framework;
using CSharpCalculator;

namespace UnitTestProjectForCalc.NUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class Divide_N : NUTestClass
    {
        Calculator calc = new Calculator();

        [OneTimeTearDown]
        public override void AfterSuite()
        {
            Console.WriteLine("Testing of Divide has been finished!");
        }

        [OneTimeSetUp]
        public override void BeforeSuite()
        {
            Console.WriteLine("Testing of Divide has been started!");
        }

        [Test]
        [TestCase("5.43", "-4.11")]   //String parameters    
        [TestCase(5, 8)]             //Double parameters
        [TestCase(6, 0)]
        [TestCase(0, 0)]
        [TestCase(1, 0.12)]
        [Description("Check that method returns result from divide of two input values")]
        public void CheckDev(object firstNumber, object secondNumber)
        {

            double actResult = calc.Divide(Double.Parse(firstNumber.ToString()), Double.Parse(secondNumber.ToString()));
            double expResult = Double.Parse(firstNumber.ToString()) / Double.Parse(secondNumber.ToString());

            Assert.AreEqual(expResult, actResult,$"{firstNumber}:{secondNumber}={expResult}, but was {actResult}");
        }
    }
}
