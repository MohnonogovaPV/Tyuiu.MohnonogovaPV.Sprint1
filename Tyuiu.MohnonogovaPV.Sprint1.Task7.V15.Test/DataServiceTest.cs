using Tyuiu.MohnonogovaPV.Sprint1.Task7.V15.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint1.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            var res = ds.Calculate(x);
            Assert.AreEqual(96.484, res);
        }
    }
}