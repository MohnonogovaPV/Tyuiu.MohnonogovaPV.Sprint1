using Tyuiu.MohnonogovaPV.Sprint1.Task2.V14.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint1.Task2.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Мохноногова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                                      *");
            Console.WriteLine("* Задание #2                                                                               *");
            Console.WriteLine("* Вариант #14                                                                               *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                  *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу, которая запришивает у пользователя исходные данные,                  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                              *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            int x;

            Console.WriteLine("Введите температуру в градусах Кельвина: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Температура в градусах Цельсия: " + ds.ConvertKelvinToCelsius(x));

            Console.ReadLine();
        }
    }
}
