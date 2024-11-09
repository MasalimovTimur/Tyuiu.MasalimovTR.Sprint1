
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MasalimovTR.Sprint1.Task1.V21.Lib;

namespace Tyuiu.MasalimovTR.Sprint1.Task1.V21.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds = new DataServise();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-1, res);
        }
    }
}


