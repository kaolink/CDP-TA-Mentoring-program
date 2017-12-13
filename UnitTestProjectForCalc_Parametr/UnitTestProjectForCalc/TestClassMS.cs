using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectForCalc
{
    [TestClass]
    abstract public class TestClassMS
    {        
        [ClassInitialize]
        abstract public void Precondition();
               
        [ClassCleanup]
        abstract public void Postcondition();
        
    }
}
