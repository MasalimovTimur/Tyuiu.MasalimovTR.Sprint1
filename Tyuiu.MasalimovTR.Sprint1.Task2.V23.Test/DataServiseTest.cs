using Tyuiu.MasalimovTR.Sprint1.Task2.V23.Lib;

namespace Tyuiu.MasalimovTR.Sprint1.Task2.V23.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds = new DataServise();
            int x = 1;
            int res = ds.ConvertMinutesToSeconds(x);
            Assert.AreEqual(60, res);
        }
    }
}