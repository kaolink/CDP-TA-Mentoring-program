using System;
using NUnit.Framework;
using CSharpCalculator;

namespace UnitTestProjectForCalc.NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.None)]
    public class Multiply_N:NUTestClass
    {
        Calculator calc = new Calculator();

        [OneTimeTearDown]
        public override void AfterSuite()
        {
            Console.WriteLine("Testing of Multiply has been finished!");
        }

        [OneTimeSetUp]
        public override void BeforeSuite()
        {
            Console.WriteLine("Testing of Multiply has been started!");
        }

        [Test]
        [TestCase("1.15","-8.094")]
        [TestCase(2.18,3.12)]
        [TestCase(5,0)]
        [TestCase(-0.2,-0.854)]
        [Description("Check that method returns result from multiply of two input values")]
        public void CheckMultiply(object firstNumber, object secondNumber)
        {

            double actResult = calc.Multiply(Double.Parse(firstNumber.ToString()), Double.Parse(secondNumber.ToString()));
            double expResult = Double.Parse(firstNumber.ToString()) * Double.Parse(secondNumber.ToString());

            Assert.AreEqual(expResult, actResult,$"{firstNumber}-{secondNumber}={expResult}, but was '{actResult}'");
        }
    }
}
