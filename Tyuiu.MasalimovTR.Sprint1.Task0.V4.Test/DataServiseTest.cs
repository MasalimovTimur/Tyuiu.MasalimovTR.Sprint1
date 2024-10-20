
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MasalimovTR.Sprint1.Task0.V4.Lib;

namespace Tyuiu.MasalimovTR.Sprint1.Task0.V4.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds = new DataServise();
            var res = ds.Calculate();
            Assert.AreEqual(6, res);
        }
    }
}
