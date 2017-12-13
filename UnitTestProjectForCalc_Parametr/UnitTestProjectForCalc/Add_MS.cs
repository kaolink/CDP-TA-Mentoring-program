using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc
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
        [DataRow("5.43","4.11")]   //String parameters
        [DataRow(5.43,7.12)]       //Double parameters
        public void CheckAdd(object firstNumber, object secondNumber)
        {

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
