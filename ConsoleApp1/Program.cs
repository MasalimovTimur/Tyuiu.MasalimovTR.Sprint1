using Tyuiu.MasalimovTR.Sprint1.Task1.V21.Lib;

namespace Tyuiu.MasalimovTR.Sprint1.Task1.V21
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataServise ds = new DataServise();

            Console.Title = "Спринт #1 | Выполнил: Масалимов Т.Р. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Русланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле (x*y)/(3+y) и печатает его на экране.    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:     (x*y)/(3+y)                                        *");
            Console.WriteLine("***************************************************************************");

            Double x, y;
            Console.WriteLine("Введите значение x, затем y");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            double result = (x * y) / (3 + y);
            Console.WriteLine("Результат: " + result);
        }
    }
}
