using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc
{
    [TestClass]
    public class Cos_MS : TestClassMS
    {
        Calculator calc = new Calculator();

        [TestCleanup]
        public override void Postcondition()
        {
            Console.WriteLine("Testing of Cos has been finished!");
        }

        [TestInitialize]
        public override void Precondition()
        {
            Console.WriteLine("Testing of Cos has been started!");
        }

        [TestMethod]
        [DataRow("0")]
        [DataRow(89.9)]
        [DataRow(90.1)]
        [DataRow(90)]
        [DataRow(-89.9)]
        [DataRow(-90)]
        [DataRow(-90.1)]
        [DataRow(360)]
        [DataRow(360.1)]

        public void CheckCos(object angle)
        {
            double actResult = calc.Cos(Double.Parse(angle.ToString()));
            double expResult = Math.Cos(Double.Parse(angle.ToString()));

            Assert.AreEqual(expResult, actResult);
        }
    }
}
