using Tyuiu.MohnonogovaPV.Sprint1.Task1.V9.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint1.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Мохноногова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                                  *");
            Console.WriteLine("* Задание #1                                                                               *");
            Console.WriteLine("* Вариант #9                                                                               *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                   *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать консольную программу, которая запришивает у пользователя исходные данные,       *");
            Console.WriteLine("* вычисляет результат по форрмуле (1 + 3 * x) / (4 * y) и печатает его на экране.            *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y; ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                                *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}