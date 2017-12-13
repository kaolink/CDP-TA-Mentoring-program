using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc
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
        [DataRow("5.43", "4.11")]   //String parameters
        [DataRow(5.43, 7.12)]       //Double parameters
        [DataRow(0, 5)]
        [DataRow(-0.1, 0.58)]
        [DataRow(5,0)]
        public void CheckPow(object number, object powNumber)
        {
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
