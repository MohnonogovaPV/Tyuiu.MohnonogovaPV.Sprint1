using Tyuiu.MohnonogovaPV.Sprint1.Task3.V2.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint1.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Мохноногова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                                  *");
            Console.WriteLine("* Задание #3                                                                               *");
            Console.WriteLine("* Вариант #2                                                                               *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                   *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу, которая запришивает у пользователя исходные данные,                  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                              *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");
            double x, y;
            int z, w;

            Console.WriteLine("Введите цену тетрадей: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество тетрадей: ");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите цену карандашей: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество карандашей: ");
            w = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Стоимость покупки: " + ds.PurchaseAmount(x, z, y, w));

            Console.ReadLine();


        }
    }
}
        
    

