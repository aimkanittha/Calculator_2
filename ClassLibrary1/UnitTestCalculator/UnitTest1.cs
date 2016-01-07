using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTest1 :  IUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string a = "10", b = "20";
            Calculator cal = new Calculator();
            string[] operatorSet = { "+", "-", "*", "/" };
            string[] sum = { "30", "-10", "200", "0.5" };
            

            for (int i = 0; i < 4; i++)
            {
                cal.getInput(a, b, operatorSet[i],new Logging(null));
                Assert.AreEqual(sum[i], cal.calculate());
            }
        }
    }
}
