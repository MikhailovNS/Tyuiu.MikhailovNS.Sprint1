using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint1.Task5.V4.Lib;

namespace Tyuiu.MikhailovNS.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int time = 13257;
            var result = ds.SecondsToHours(time);
            int wait = 3;
            Assert.AreEqual(wait, result);


        }
    }
}
