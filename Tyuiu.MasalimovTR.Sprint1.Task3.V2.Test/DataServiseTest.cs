using Tyuiu.MasalimovTR.Sprint1.Task3.V2.Lib;

namespace Tyuiu.MasalimovTR.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServise ds = new DataServise();
            double priceNotebook = 1.1;
            double pricePencil = 1.3;
            int amountNotebook = 11;
            int amountPencil = 10;
            double wait = priceNotebook * amountNotebook + pricePencil * amountPencil;
            double res = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            Assert.AreEqual(wait, res);
        }
    }
}