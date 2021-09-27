using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Homework
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1.1");
            Console.Write("Введите действительное число x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Его абсолютная величина равна {Abs(x)}");

            Console.WriteLine("\nTask 1.2");
            Console.Write("Введите действительное число x = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите действительное число x = ");
            double y = Convert.ToDouble(Console.ReadLine());
            x = Abs(x) > Abs(y) ? x / 2 : x;
            Console.WriteLine($"После преобразования x = {x}");

            Console.WriteLine("\nTask 1.3");
            string s = Console.ReadLine();

            
        }
        static double Abs(double x)
        {
            x = x > 0 ? x : -x;
            return x;
        }
    }
}
