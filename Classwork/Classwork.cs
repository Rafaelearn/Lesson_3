using System;

namespace Classwork
{
    class Classwork
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("\nTask 1");
            bool flag = true;
            Console.Write("Введите трехзначное положительное число: ");
            while (flag)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                if (i > 999 || i < 99)
                {
                    Console.Write("Число должно быть трехзначным, попробуй снова: ");
                }
                else
                {
                    if(i / 100 == i % 10)
                    {
                        Console.WriteLine("Введенное число полиндром");
                    }
                    else
                    {
                        Console.WriteLine("Введенное число не является полидромом");
                    }
                    flag = false;
                }
            }

            Console.WriteLine("\nTask 2");
            double a = random.NextDouble() * 60; 
            double b = random.NextDouble() * 60;
            double x = random.NextDouble() * 20;
            Console.WriteLine($"Диаметр головы Васи диаметром {x}. Размеры окна {a} x {b}");
            if (x < a + 2 && x < b + 2) 
            {
                Console.WriteLine("Вася смог высунуть голову");
            }
            else
            {
                Console.WriteLine("У Васи ничего не получается...");
            }

            Console.WriteLine("\nTask 3");
            Console.Write("Введите порядковый номер дня недели (1-7): ");
            x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wendnesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Жаль, но для такого порядкого номера дня недели не сущетсвует");
                    break;
            }


            Console.WriteLine("\nTask 5");
            Console.WriteLine("Земля — идеальная сфера с радиусом R = 6370 км." +
                " h - высота до линии горизонта. а - расстояние до линнии гоизонта");
            x = 6370;
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"При h = {i}, a = {Math.Sqrt(i * (2*x + i))} км.");
                
            }

            Console.WriteLine("\nTask 6");
            flag = true;
            Console.Write("Введите цифру:");
            while (flag)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x > 9 || x < 1)
                {
                    Console.Write("Число должно быть натуральным и меньше 9, попробуй снова: ");
                }
                else
                {
                    for (int i = 1; i < 11; i++)
                    {
                        Console.WriteLine($"{x} * {i} = {x * i}" );
                        flag = false;
                    }
                }
            }

            Console.WriteLine("\nTask 8");
            int[] sequence = new int[10];
            for (int i = 0; i < 10; i++)
            {
                sequence[i] = random.Next(500);
                Console.WriteLine($"A[{i}] = {sequence[i]}");
            }
            
            flag = true;
            x = sequence[0];
            for (int i = 0; i < 10; i++)
            {
                if (sequence[i] < x)
                {
                    Console.WriteLine($"Последовательность неупорядоченная. A[{i}] нарушает порядок возрастания!");
                    break;
                }
                x = sequence[i];
            }
            if (flag)
            {
                Console.WriteLine("Данная последовательность упорядоченная по возрастанию!");
            }

            Console.WriteLine("\nTask 9");

            Console.WriteLine("\nTask 10");
            Console.WriteLine("А - последовательность");
            x = 0; a = 1; b = 0;
            Start:
            Console.Write($"A[{a}] = ");
            x = Convert.ToInt32(Console.ReadLine());
            if (a % 3 == 0)
            {
                b += x;
            }
            a++;
            if (x != 0)
            {
                goto Start;
            }
            Console.WriteLine($"Cумма элеентов с порядковым номер кратным трем равна: {b}");



        }
    }
}
