using Tyuiu.MasalimovTR.Sprint1.Task5.V2.Lib;

namespace Tyuiu.MasalimovTR.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
             DataService ds = new DataService();
            double temp = 32;
            double res = ds.FahrenheitTo—elsius(temp);
            Assert.AreEqual(0, res);
        }
    }
}