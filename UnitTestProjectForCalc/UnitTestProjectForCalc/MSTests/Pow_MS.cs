using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc.MSTests
{
    [TestClass]
    public class Pow_MS:TestClassMS
    {
        Calculator calc = new Calculator();

        [TestInitialize]
        public override void Precondition()
        {
            Console.WriteLine("Testing of Pow has been started!");
        }

        [TestMethod]
        public void CheckPow()
        {
            object number = "5.43";
            object powNumber = 7.12;
            double actResult = calc.Pow(number,powNumber);
            double expResult = Math.Pow(Double.Parse(number.ToString()), Double.Parse(powNumber.ToString()));

            Assert.AreEqual(expResult, actResult);
        }

        [TestCleanup]
        public override void Postcondition()
        {
            Console.WriteLine("Testing of Pow has been finished!");
        }
    }
}
