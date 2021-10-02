using System;

namespace Homework
{
    class Homework
    {
        static void Main(string[] args)
        {
            var random = new Random();

            Console.WriteLine("Task 1.1");
            Console.Write("Введите действительное число x = ");
            bool flag = double.TryParse(Console.ReadLine(), out double x);
            if (flag)
            {
                Console.WriteLine($"Его абсолютная величина равна {Abs(x)}");
            }
            else
            {
                Console.WriteLine("Вы ввели неправильное значение;");
            }

            Console.WriteLine("\nTask 1.2");
            double y;
            try
            {
                Console.Write("Введите действительное число x = ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите действительное число x = ");
                y = Convert.ToDouble(Console.ReadLine());
                x = Abs(x) > Abs(y) ? x / 2 : x;
                Console.WriteLine($"После преобразования x = {x}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nTask 1.3");
            Console.Write("Введите животное(alligator): ");
            string s = Console.ReadLine();
            s = s.ToLower() != "alligator" ? "wide": "small";
            Console.WriteLine($"mouthSize = {s}");

            Console.WriteLine("\nTask 1.4");
            try
            {
                Console.Write("Input string: ");
                s = Console.ReadLine();
                switch (s.ToLower())
                {
                    case "jabroni":
                        Console.WriteLine("Patron Tequilla");
                        break;
                    case "school counselor":
                        Console.WriteLine("Anything with Alcohol");
                        break;
                    case "programmer":
                        Console.WriteLine("Hipster Craft Beer");
                        break;
                    case "bike gang member":
                        Console.WriteLine("Moonshine");
                        break;
                    case "politcian":
                        Console.WriteLine("Your tax dollars");
                        break;
                    case "rapper":
                        Console.WriteLine("Cristal");
                        break;
                    default:
                        Console.WriteLine("Beer");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nTask 1.5");
            Console.Write("Input string: ");
            s = Console.ReadLine();
            Console.WriteLine($"String contains \"english\": {s.ToLower().Contains("english")}");

            Console.WriteLine("\nTask 2.1");
            x = 1; double sum;
            for (int i = 0; i < 9; i++)
            {
                x /= 3;
            }
            sum = (x - 1) / (-2.0 / 3); //Cумма геометрической прогрессии для q = 1/3
            Console.WriteLine($"Искомая сумма равна {sum}");

            Console.WriteLine("\nTask 2.2");
            sum = 0;
            for (int i = 1; i < 101; i++)
            {
                sum = i % 2 == 0 ? sum - 1.0 / i : sum + 1.0 / i;
            }
            sum = 0;
            // Сумма первых 100 членов гармонического ряда
            // S(x) = ln(x) + q (q = 0,5772156649....)
            //sum  = Math.Log(100) + 0.5772156649;
            for (int i = 1; i < 101; i++)
            {
                sum += 1.0 / i;
            }
            Console.WriteLine($"Общий путь мужчины: {sum}");

            Console.WriteLine("\nTask 2.3");
            sum = 0; y = 0;
            for (int i = 0; i < 31; i++)
            {
                x = random.NextDouble() * 20;
                sum += x;
                x = random.NextDouble() * 12;
                y += x;
            }
            Console.WriteLine($"\"\nСреднее количество осадков за март {Math.Round(sum / 30, 3)} мм.");
            Console.WriteLine($"\"\nСреднее количество осадков за январь {Math.Round(y / 30, 3)} мм.");

            Console.WriteLine("\nTask 3.1");
            x = 1; y = 1; double temp;
            while (Math.Abs(x / y - (x + y) / x) > 0.001)
            {
                temp = x;
                x += y;
                y = temp;
            }
            Console.WriteLine($"Ответ задачи 3.1: {x + y}/{x}");

            Console.WriteLine("\nTask 3.2");
            Console.Write("Введите число x: ");
            x = Convert.ToDouble(Console.ReadLine()); y = 1;
            while (y * y <= x) { y++; }
            Console.WriteLine($"Первое натуральное  число, квадрат к-ого больше x: {y}");

            Console.WriteLine("\nTask 3.3");
            x = 100;
            while (x > 79)
            {
                Console.WriteLine(x);
                x--;
            }
            x = 100;
            do
            {
                Console.WriteLine(x);
                x--;
            } while (x > 79);

            Console.WriteLine("\nTask 3.4");
            x = 5000;
            while (x % 39 != 0)
            {
                x--;
            }
            Console.WriteLine("максимальное из натуральных чисел, не превышающих 5000," +
                $" которое нацело делится на 39 {x}");

            Console.WriteLine("\nTask 3.5");
            s = "";
            for (int i = 0; i < 5; i++)
            {
                s += "5 ";
                Console.WriteLine(s);
            }
            s = "1 1 1 1 1 ";
            for (int i = 4; i > -1; i--)
            {
                Console.WriteLine(s);
                s = s.Substring(0, i * 2);
            }

            Console.WriteLine("Chess");
            flag = true;
            Console.WriteLine("Поле шахматной доски определяется парой натуральных чисел," +
                " каждое из которых непревосходит 8: первое число — номер вертикали" +
                "(при счете слева направо), второе — номер горизонтали(при счете снизу вверх). " +
                "Даны натуральные числа a, b, c, d, каждое из которых не превосходит 8.");
            while (flag)
            {
                Console.Write("a = ");
                byte.TryParse(Console.ReadLine(), out byte a);
                Console.Write("b = ");
                byte.TryParse(Console.ReadLine(), out byte b);
                Console.Write("c = ");
                byte.TryParse(Console.ReadLine(), out byte c);
                Console.Write("d = ");
                byte.TryParse(Console.ReadLine(), out byte d);
                if (a == 0 || b == 0 || c == 0 || d == 0 || a > 8 || b > 8 || c > 8 || d > 8)
                {
                    Console.WriteLine("Введенные значения не удовлетворяют" +
                        " условиям задания. Попробуй снова:");
                }
                else
                {
                    bool rookBool = a == c || b == d;
                    Console.Write($"Ладья с поля ({a}, {b}) полю ({c}, {d}): ");
                    if (!(rookBool))
                    {
                        Console.WriteLine("не угрожает");
                    }
                    else
                    {
                        Console.WriteLine("угрожает");
                    }

                    bool elephBool = (a - c) * (a - c) == (b - d) * (b - d);
                    Console.Write($"Слон с поля ({a}, {b}) полю ({c}, {d}): ");
                    if (!elephBool)
                    {
                        Console.WriteLine("не угрожает");
                    }
                    else
                    {
                        Console.WriteLine("угрожает");
                    }


                    Console.Write($"Король с поля ({a}, {b}) на поле ({c}, {d}) ");
                    if (!((a - c) * (a - c) < 2 && (b - d) * (b - d) < 2))
                    {
                        Console.WriteLine("не может попасть за 1 ход");
                    }
                    else
                    {
                        Console.WriteLine("может попасть за 1 ход");
                    }

                    Console.Write($"Ферзь с поля ({a}, {b}) полю ({c}, {d}): ");
                    if (!(rookBool || elephBool))
                    {
                        Console.WriteLine("не угрожает");
                    }
                    else
                    {
                        Console.WriteLine("угрожает");
                    }

                    Console.Write($"Белая пешка с поля ({a}, {b}) на поле ({c}, {d}) при обычном ходе ");
                    if (!(a == c && d - b == 1))
                    {
                        Console.WriteLine("не может попасть за 1 ход");
                    }
                    else
                    {
                        Console.WriteLine("может попасть за 1 ход");
                    }
                    Console.Write($"Белая пешка с поля ({a}, {b}) на поле ({c}, {d}), когда она бъет,  ");
                    if (!((a - c) * (a - c) == 1 && d - b == 1))
                    {
                        Console.WriteLine("не может попасть за 1 ход");
                    }
                    else
                    {
                        Console.WriteLine("может попасть за 1 ход");
                    }

                    Console.Write($"Черная пешка с поля ({a}, {b}) на поле ({c}, {d}) при обычном ходе ");
                    if (!(a == c && b - d == 1))
                    {
                        Console.WriteLine("не может попасть за 1 ход");
                    }
                    else
                    {
                        Console.WriteLine("может попасть за 1 ход");
                    }
                    Console.Write($"Черная пешка с поля ({a}, {b}) на поле ({c}, {d}), когда она бъет,  ");
                    if (!((a - c) * (a - c) == 1 && b - d == 1))
                    {
                        Console.WriteLine("не может попасть за 1 ход");
                    }
                    else
                    {
                        Console.WriteLine("может попасть за 1 ход");
                    }

                    Console.Write($"Конь с поля ({a}, {b}) полю ({c}, {d}): ");
                    if ((a - c) * (a - c) * (b - d) * (b - d) != 4)
                    {
                        Console.WriteLine("не угрожает");
                    }
                    else
                    {
                        Console.WriteLine("угрожает");
                    }
                    flag = false;
                }
            }

            Console.WriteLine("Interesting task");
            var numUser = new int[100]; var numHacker = new int[100];
            byte order = 0; long suma = 0;
            for (int i = 0; i < 100; i++)
            {
                numUser[i] = random.Next();
                numHacker[i] = 1; //Реализация первой передачи 
            }
            Console.WriteLine("User numbers");
            foreach (var item in numUser)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine("\nПередача №1: сложения всех натуральных чисел программиста для поиска наивысшего порядка.");
            for (int i = 0; i < 100; i++)
            {
                suma += numHacker[i] * numUser[i];
            }
            Console.WriteLine($"Cумма чисел программиста: {sum}");
            order = (byte)sum.ToString().Length;
            Console.WriteLine($"Наивысший порядок: {order}");
            Console.WriteLine("Передача №2 - numHacker[i] = 10^(order*i). Итог передачи:  ");
            string numberHuge = numUser[99].ToString();
            for (int i = 98; i > -1; i--)
            {
                numberHuge += "000000000000".Substring(0, order - numUser[i].ToString().Length) + numUser[i].ToString();
            }
            Console.WriteLine(numberHuge);
            Console.WriteLine("Из данного ОГРОМНОГО числа видны все числа программиста. А имеено: ");
            numberHuge = numberHuge.Insert(0, "000000000000000".Substring(0, order - numUser[99].ToString().Length));
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{100-i}-ое число пользователя: {numberHuge.Substring(i*order, order).Trim('0')}");
            }
            
            Console.ReadKey();
        }
        static double Abs(double x)
        {
            x = x > 0 ? x : -x;
            return x;
            
        }
        
    }
}
