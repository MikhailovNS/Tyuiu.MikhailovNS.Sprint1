using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint1.Task2.V6.Lib;

namespace Tyuiu.MikhailovNS.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 5000;
            var res = ds.ConvertMToKm(x);
            Assert.AreEqual(5, res);


        }
    }
}
