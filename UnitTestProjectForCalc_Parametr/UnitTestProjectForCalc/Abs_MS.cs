using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc
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
        [DataRow("-0.2")]
        [DataRow(-1.1)]      // Bug
        [DataRow(0.1)]      // Bug
        [DataRow(0)]
        public void CheckAbs(object number)
        {
            double actResult = calc.Abs(Double.Parse(number.ToString()));
            double expResult = Math.Abs(Double.Parse(number.ToString()));


            Assert.AreEqual(expResult,actResult);

        }
    }
}
