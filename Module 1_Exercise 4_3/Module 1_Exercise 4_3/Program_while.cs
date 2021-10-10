using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_4_3
{
    class Program_while
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день! Введите горизонтальную сторону прямоугольника.");
            int lenA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вертикальную сторону прямоугольника.");
            int lenB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите сторону квадрата C.");
            int lenC = Convert.ToInt32(Console.ReadLine());

            int num = 0;
            int numB = 0;

            while (lenB >= lenC)
            {
                lenB = lenB - lenC;
                numB++;
            }
            while (lenA >= lenC)
            {
                lenA = lenA - lenC;
                num += numB;
            }

            Console.WriteLine("По вертикали поместится: {0}", numB);
            Console.WriteLine("Всего поместится: {0}", num);
            Console.ReadKey();
        }
    }
}
