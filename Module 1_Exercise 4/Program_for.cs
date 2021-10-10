using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_4
{
    class Program_for
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день! Введите целое число (N > 0)");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum = sum + (2 * i - 1);
                Console.WriteLine("Текущее значение суммы: {0}", sum);
            }

            Console.WriteLine();
            Console.WriteLine("Квадрат искомого числа: {0}", sum);
            Console.ReadKey();
        }
    }
}
