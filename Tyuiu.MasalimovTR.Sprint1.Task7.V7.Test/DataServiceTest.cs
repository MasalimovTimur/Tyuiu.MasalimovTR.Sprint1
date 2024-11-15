using Tyuiu.MasalimovTR.Sprint1.Task7.V7.Lib;

namespace Tyuiu.MasalimovTR.Sprint1.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(-12.57, res);
        }
    }
}