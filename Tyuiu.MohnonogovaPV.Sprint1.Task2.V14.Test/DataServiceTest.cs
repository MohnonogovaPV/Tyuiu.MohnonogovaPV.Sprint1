using Tyuiu.MohnonogovaPV.Sprint1.Task2.V14.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint1.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 274;
            var res = ds.ConvertKelvinToCelsius(x);
            Assert.AreEqual(1, res);
        }
    }
}