using Tyuiu.MohnonogovaPV.Sprint1.Task4.V9.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 29;
            double y = 2;
            double wait = 0.152;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}