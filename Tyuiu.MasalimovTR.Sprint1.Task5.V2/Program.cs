using Tyuiu.MasalimovTR.Sprint1.Task5.V2.Lib;

namespace Tyuiu.MasalimovTR.Sprint1.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Масалимов Т.Р. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Русланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано значение температуры в градусах Фаренгейта.,                       *");
            Console.WriteLine("* Определить значение этой же температуры в градусах Цельсия              *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите градусы в фаренгейтах");

            double temp = Convert.ToDouble(Console.ReadLine());
            DataService ds = new DataService();
            double res = ds.FahrenheitToСelsius(temp);
            Console.WriteLine("Результат: " + res + " градусов цельсия");
        }
    }
}
