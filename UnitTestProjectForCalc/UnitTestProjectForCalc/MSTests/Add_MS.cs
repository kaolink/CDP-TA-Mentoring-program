using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc.MSTests
{
    [TestClass]
    public class Add_MS : TestClassMS
    {
        Calculator calc = new Calculator();

        [TestInitialize]
        public override void Precondition()
        {
            Console.WriteLine("Testing of Add has been started!");
        }

        [TestMethod]
        public void CheckAdd()
        {
            object firstNumber = "2.12";
            object secondNumber = 7.15;

            double actResult = calc.Add(Double.Parse(firstNumber.ToString()), Double.Parse(secondNumber.ToString()));            
            double expResult = Double.Parse(firstNumber.ToString()) + Double.Parse(secondNumber.ToString());

            Assert.AreEqual(expResult, actResult);
        }

        [TestCleanup]
        public override void Postcondition()
        {
            Console.WriteLine("Testing of Add has been finished!");
        }

    }
}
