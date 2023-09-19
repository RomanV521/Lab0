using System;

namespace Lab0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AT-212 \nVariant 1\n");
            task1();
        }
        /// <summary>
        /// 1) Реализовать функцию вычисления суммы двух целых чисел
        /// </summary>
        static void task1()
        {
            Random random = new Random();
            int startRange = -1000, endRange = 1000;
            int number1 = random.Next(startRange, endRange), number2 = random.Next(startRange, endRange);

            Console.WriteLine("1) Реализовать функцию вычисления суммы двух целых чисел:");
            
            if (number2 < 0)
            {
                Console.WriteLine("\t{0} + ({1}) = {2}", number1, number2, Sum(number1, number2));
            }
            else{
                Console.WriteLine("\t{0} + {1} = {2}", number1, number2, Sum(number1, number2));
            }   
        }

        /// <summary>
        /// Функция возвращает сумму двух целых чисел
        /// </summary>
        /// <param name="number1">Первое слагаемое</param>
        /// <param name="number2">Второе слагаемое</param>
        /// <returns>Сумма</returns>
        static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}