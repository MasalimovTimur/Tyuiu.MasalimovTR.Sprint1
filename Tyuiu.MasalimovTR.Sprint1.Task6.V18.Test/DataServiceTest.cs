using Tyuiu.MasalimovTR.Sprint1.Task6.V18.Lib;

namespace Tyuiu.MasalimovTR.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string x = "123" ;
            bool value = ds.CheckNumber(x);
            Assert.IsTrue(value);
        }
    }
}