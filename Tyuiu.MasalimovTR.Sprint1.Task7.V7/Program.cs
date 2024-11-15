using Tyuiu.MasalimovTR.Sprint1.Task7.V7.Lib;


namespace Tyuiu.MasalimovTR.Sprint1.Task7.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Масалимов Т.Р. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #27                                                              *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Русланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.    *");
            Console.WriteLine("*Формула: ((Math.Cos(x)) / (Math.PI - 2 * Math.Pow(y, x))) + 16 * x * Math.Cos(x * y) - 2       *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите переменные x и y");

            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            DataService ds = new DataService();
            double res = ds.Calculate(x, y);
            Console.WriteLine("Результат: " + res);
        }
    }
}
