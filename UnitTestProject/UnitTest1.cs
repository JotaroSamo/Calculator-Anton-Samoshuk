using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            int a = 1;
            string dis = "2";
            string expected = "21";
            Formcal ts = new Formcal();
            string result = ts.Add(a,dis);
            Assert.AreEqual(expected,result,"Eror!");
        }
        [TestMethod]
        public void TestDoCalculate()
        {
         int count =1;
            float numo = 2;
            float displayf = 2;
            string expected = "4";
            Calculate calculate = new Calculate();
            string result = calculate.DoCalculate(count,numo,displayf);
            Assert.AreEqual(expected, result, "Eror!");

        }
        [TestMethod]
        public void Testbacker()
        {

            string displayf = "22";
            string expected = "2";
            Calculate calculate = new Calculate();
            string result = calculate.backer(displayf);
            Assert.AreEqual(expected, result, "Eror!");

        }

    }
}
