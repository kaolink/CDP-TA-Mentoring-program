using System;
using NUnit.Framework;
using CSharpCalculator;

namespace UnitTestProjectForCalc.NUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class Sub_N : NUTestClass
    {
        Calculator calc = new Calculator();

        [OneTimeTearDown]
        public override void AfterSuite()
        {
            Console.WriteLine("Testing of Sub has been finished!");
        }

        [OneTimeSetUp]
        public override void BeforeSuite()
        {
            Console.WriteLine("Testing of Sub has been started!");
        }

        [Test]
        [TestCase("1854", "-254")]   //String parameters
        [TestCase(1, 5)]             //Double parameters
        [TestCase(-658, -958)]
        [Description("Check that method returns result from subtraction of two input values")]
        public void CheckSub(object firstNumber, object secondNumber)
        {

            double actResult = calc.Sub(Double.Parse(firstNumber.ToString()), Double.Parse(secondNumber.ToString()));
            double expResult = Double.Parse(firstNumber.ToString()) - Double.Parse(secondNumber.ToString());

            Assert.AreEqual(expResult, actResult, $"{firstNumber}-{secondNumber}={expResult}, but was '{actResult}'");
        }
    }
}
