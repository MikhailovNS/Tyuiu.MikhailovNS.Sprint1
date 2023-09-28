using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint1.Task7.V16.Lib;

namespace Tyuiu.MikhailovNS.Sprint1.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            var res = ds.Calculate(x);
            double wait = 1.022;
            Assert.AreEqual(wait, res); ;
        }
    }
}
