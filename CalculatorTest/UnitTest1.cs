using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void level1Test()
        {
            Calculator c = new Calculator();
            c.SetLevel(1);

            Assert.AreEqual(c.Evaluate(), c.ToString());

        }
    }
}
