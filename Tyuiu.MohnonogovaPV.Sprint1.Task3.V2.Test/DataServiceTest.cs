using Tyuiu.MohnonogovaPV.Sprint1.Task3.V2.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 20;
            int z = 2;
            double y = 10;
            int w = 4;
            double wait = 80;
            var res = ds.PurchaseAmount(x, z, y, w);
            Assert.AreEqual(wait, res);

        }
    }
}