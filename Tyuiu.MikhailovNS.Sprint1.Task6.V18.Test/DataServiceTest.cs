using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint1.Task6.V18.Lib;

namespace Tyuiu.MikhailovNS.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string test = "132,5";
            var res = ds.CheckNumber(test);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
