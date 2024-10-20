using Tyuiu.MasalimovTR.Sprint1.Task0.V4.Lib;

namespace Tyuiu.MasalimovTR.Sprint1.Task0.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();

            Console.Title = "Спринт #1 | Выполнил: Масалимов Т.Р. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Русланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 4/2*5/(3+2)*(5-2)       *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:     4/2*5/(3+2)*(5-2)                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат выражения 4/2*5/(3+2)*(5-2) = " + ds.Calculate());
        }
    }
}

