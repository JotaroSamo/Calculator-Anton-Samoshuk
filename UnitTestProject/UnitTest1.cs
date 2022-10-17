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
        public void TestCounting()
        {
            int count = 1;
            float numo=1;
            float numt=0;
            float displayf=1;
            string expected = "2";
            Formcal ts = new Formcal();
            string result = ts.Counting(count,numo,numt,displayf);
            Assert.AreEqual(expected, result, "Eror!");
        }

    }
}
