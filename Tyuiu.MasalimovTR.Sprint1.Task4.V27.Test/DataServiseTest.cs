using Tyuiu.MasalimovTR.Sprint1.Task4.V27.Lib;

namespace Tyuiu.MasalimovTR.Sprint1.Task4.V27.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds= new DataServise();
            double x = 1;
            double y = 4;
            double res= ds.Calculate(x, y);
            Assert.AreEqual(-1.0000000000000002 , res);
        }
    }
}