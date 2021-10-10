using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_4_2
{
    class Program_doWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день! Начинайте вводить последовательность чисел. Чтобы закончить - введите 0.");

            int num = 0;
            int numPositive = 0;
            int numNegative = 0;

            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                // Анализ
                if (num > 0)
                {
                    numPositive++;
                }
                if (num < 0)
                {
                    numNegative++;
                }
                // Вывод информации
                if (num != 0)
                {
                    Console.WriteLine("Вы ввели: {0}. Сейчас положительных: {1}, отрицательных: {2}", num, numPositive, numNegative);
                }
                else
                {
                    Console.WriteLine("Вы ввели: 0. Выходим из последовательности.");
                }

            } while (num != 0);
            
            
            Console.WriteLine();
            Console.WriteLine("В итоге вы ввели положительных: {0}, отрицательных: {1}", numPositive, numNegative);
            Console.ReadKey();

        }
    }
}
