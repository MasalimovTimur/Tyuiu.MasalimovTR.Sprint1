using Tyuiu.MasalimovTR.Sprint1.Task6.V18.Lib;

namespace Tyuiu.MasalimovTR.Sprint1.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Масалимов Т.Р. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                              *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Русланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
            Console.WriteLine("* Проверить, что строка является символьным представлением натурального числа (\"122\", \"34\" и т.д.).    *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Console.WriteLine("Введите текст:");
            string x = Console.ReadLine();

            if (ds.CheckNumber(x))
            {
                Console.WriteLine("Строка является натуральным числом.");
            }
            else
            {
                Console.WriteLine("Строка не является натуральным числом.");
            }
        }

    }
}
