using Tyuiu.MohnonogovaPV.Sprint1.Task5.V4.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint1.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Мохноногова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                                               *");
            Console.WriteLine("* Задание #5                                                                               *");
            Console.WriteLine("* Вариант #4                                                                               *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                   *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу, которая решает чледующую задачу:                                     *");
            Console.WriteLine("* Идет k-я секунда суток. Определить, сколько полных часов прошло к этому моменту.         *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Введите секунду суток: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("К этому моменту прошло " + ds.SecondsToHours(k) + " часов");

            Console.ReadKey();
        }
    }
}
