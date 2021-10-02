using System;

namespace Classwork
{
    class Classwork
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Task 1");
            bool flag = true;
            Console.Write("Введите трехзначное положительное число: ");
            while (flag)
            {
                int.TryParse(Console.ReadLine(), out int i);
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
            double a = Math.Round(random.NextDouble() * 60, 4); 
            double b = Math.Round(random.NextDouble() * 60, 4);
            double x = Math.Round(random.NextDouble() * 20, 4);
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
            double.TryParse(Console.ReadLine(), out x);
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

            Console.WriteLine("\nTask 4");
            try
            {
                Console.WriteLine("Введите порядковый номер карты k (6 <= k <= 14): ");
                x = Convert.ToSByte(Console.ReadLine());
                Console.Write("Ваша карта");
                switch (x)
                {
                    case 6:
                        Console.WriteLine("Шестерка");
                        break;
                    case 7:
                        Console.WriteLine("Семерка");
                        break;
                    case 8:
                        Console.WriteLine("Восьмерка");
                        break;
                    case 9:
                        Console.WriteLine("Девятка");
                        break;
                    case 10:
                        Console.WriteLine("Десятка");
                        break;
                    case 11:
                        Console.WriteLine("Валет");
                        break;
                    case 12:
                        Console.WriteLine("Дама");
                        break;
                    case 13:
                        Console.WriteLine("Король");
                        break;
                    case 14:
                        Console.WriteLine("Туз");
                        break;
                    default:
                        Console.WriteLine("\nТакой карты не существует");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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

            Console.WriteLine("\nTask 7");
            try
            {
                Console.WriteLine("A - последовательность. А[n] - член последовательности.");
                flag = true; a = 1; b = 0;
                while(flag)
                {
                    Console.Write($"A[{a}] = ");
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x < 0)
                    {
                        Console.WriteLine($"Среднее арифметическое A[n] > 0: {b / a}");
                        flag = false;
                    }
                    b += x; a++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nTask 8");
            var sequence = new int[10];
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    sequence[i] = random.Next(500);
                    Console.WriteLine($"A[{i}] = {sequence[i]}");
                }
                x = sequence[0]; flag = true;
                for (int i = 0; i < 10; i++)
                {
                    if (sequence[i] < x)
                    {
                        Console.WriteLine($"Последовательность неупорядоченная. A[{i}] нарушает порядок возрастания!");
                        flag = false; break;
                    }
                    x = sequence[i];
                }
                if (flag)
                {
                    Console.WriteLine("Данная последовательность упорядоченная по возрастанию!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
            Console.WriteLine("\nTask 9");
            Console.WriteLine("А - последовательность чисел");
            a = 1; b = 0;
            while (x != 0)
            {
                Console.Write($"A[{a}] = ");
                x = Convert.ToInt32(Console.ReadLine());
                if (a % 3 == 0)
                {
                    b += x;
                }
                a++;
                //А  зачем continue ???
            }
            Console.WriteLine($"Cумма элементов с порядковым номер кратным трем равна: {b}");

            Console.WriteLine("\nTask 10");
            Console.WriteLine("А - последовательность");
            a = 1; b = 0;
            Start:
            Console.Write($"A[{a}] = ");
            x = Convert.ToInt32(Console.ReadLine());
            b += x;
            a++;
            if (x != 0)
            {
                goto Start;
            }
            Console.WriteLine($"Cумма элементов равна: {b}");

            Console.ReadKey();
        }
    }
}
