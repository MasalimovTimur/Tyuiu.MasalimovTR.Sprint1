using Tyuiu.MasalimovTR.Sprint1.Task2.V23.Lib;

namespace Tyuiu.MasalimovTR.Sprint1.Task2.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Масалимов Т.Р. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Рyсланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Формулировка задания: Задано количество минут. Перевести время в секунды*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*  Что пользователь вводит? Время в минутах (целое число)                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Что программа печатает на экране? Время в секундах (целое число)        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите колличесво минут");
            DataServise ds = new DataServise();
            int x = ds.ConvertMinutesToSeconds(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Кол-во секунд:" + x);
        }
    }
}
