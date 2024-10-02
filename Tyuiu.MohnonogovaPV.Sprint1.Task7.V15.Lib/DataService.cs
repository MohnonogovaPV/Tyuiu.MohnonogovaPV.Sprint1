using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MohnonogovaPV.Sprint1.Task7.V15.Lib
{
    public class DataService : ISprint1Task7V15
    {
        public double Calculate(double x)
        {
            var res = Math.Round(Math.Abs((x * x - x * x * x)) - ((Math.Cos(x * x * x)) + 7 * (Math.Pow(x, 2)) / (Math.Pow(x, 3)) - 15 * x), 3);
            return res;
        }
    }
}
