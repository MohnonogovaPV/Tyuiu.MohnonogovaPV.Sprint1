using Tyuiu.MohnonogovaPV.Sprint1.Task1.V9.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint1.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.5, res);
        }
    }
}
