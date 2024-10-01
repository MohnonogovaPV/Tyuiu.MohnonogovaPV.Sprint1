using Tyuiu.MohnonogovaPV.Sprint1.Task6.V9.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string wrds = "каша наша";
            DataService ds = new DataService();
            string res = ds.MoveLetterToStart(wrds);
            string itog = "акаш анаш";
            Assert.AreEqual(itog, res);
            
        }
    }
}