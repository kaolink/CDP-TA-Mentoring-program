using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc.MSTests
{
    [TestClass]
    public class Abs_MS : TestClassMS
    {
        Calculator calc = new Calculator();

        [TestCleanup]
        public override void Postcondition()
        {
            Console.WriteLine("Testing of Abs has been finished!");
        }

        [TestInitialize]
        public override void Precondition()
        {
            Console.WriteLine("Testing of Abs has been started!");
        }

        [TestMethod]
        public void CheckAbs()
        {
            object number = "-0.2";

            double actResult = calc.Abs(Double.Parse(number.ToString()));
            double expResult = Math.Abs(Double.Parse(number.ToString()));


            Assert.AreEqual(expResult,actResult);

        }
    }
}
