namespace Tyuiu.MasalimovTR.Sprint1.Task4.V27
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
            Console.WriteLine("*Формула: (1 + Math.Sin(Math.PI * x)) / (x - Math.Sqrt(Math.Abs(y)))       *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите переменные x и y");

            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double res = (1 + Math.Sin(Math.PI * x)) / (x - Math.Sqrt(Math.Abs(y)));
            Console.WriteLine("Результат: " + res );
        }
    }
}
