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
            double x = 2;
            var res = ds.Calculate(x);
            Assert.AreEqual(30.646, res);
        }
    }
}