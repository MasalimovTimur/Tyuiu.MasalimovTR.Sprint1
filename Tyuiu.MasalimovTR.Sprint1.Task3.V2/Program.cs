using Tyuiu.MasalimovTR.Sprint1.Task3.V2.Lib;

namespace Tyuiu.MasalimovTR.Sprint1.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Масалимов Т.Р. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Русланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.    *");
            Console.WriteLine("* Объявите необходимые переменные и напишите программу вычисления стоимости покупки     *");
            Console.WriteLine("* состоящей из нескольких тетрадей и карандашей                            *");
            Console.WriteLine("* Предполагается, что пользователь будет вводить данные о каждой составляющей покупки в отдельной строке:*");
            Console.WriteLine("* сначала цену, затем количество.                                                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите цену(руб) тетрадей и цену карандашей а также их количество соответственно");

            double priceNotebook = Convert.ToDouble(Console.ReadLine());
            double pricePencil = Convert.ToDouble(Console.ReadLine());
            int amountNotebook = Convert.ToInt32(Console.ReadLine());
            int amountPencil = Convert.ToInt32(Console.ReadLine());
            double sum = Math.Round(priceNotebook * amountNotebook + pricePencil * amountPencil, 3);
            Console.WriteLine("Стоимость " + sum + " руб");

        }
    }
}
