using Tyuiu.MohnonogovaPV.Sprint1.Task7.V15.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint1.Task7.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Мохноноговаа П. В. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                  *");
            Console.WriteLine("* Задание #7                                                                               *");
            Console.WriteLine("* Вариант #15                                                                               *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                 *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение                           *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                                    *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            double x;

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("|x^2 - x^3| - (cos(x^3) + 7*x^2) / (x^3 - 15*x) = " + ds.Calculate(x));

            Console.ReadKey();
        }
    }
}
