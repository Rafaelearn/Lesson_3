using System;
namespace Lab_3
{
    enum Mounth
    {
        January,
        February,
        March,
        April, 
        May,
        June,
        July,
        August,
        September,
        Ocober,
        November,
        December
    }
    class Laboratory
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All laboratory work");
            var dayMonths = new byte[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Console.Write("Введите год: ");
            ushort dayAdd = Convert.ToUInt16(Console.ReadLine());
            dayAdd =  (ushort)(dayAdd % 400 == 0 || dayAdd % 4 == 0 && !(dayAdd % 100 == 0) ? 1 : 0);
            if(dayAdd == 1)
            {
                Console.WriteLine("Введенный год високосный");
                dayMonths[1]++;
            }
            else
            {
                Console.WriteLine("Введенный год невисокосный");
            }
            Console.Write("Введите порядковый номер дня в текущем году: ");
            ushort day; bool flag = true;
            while (flag)
            {
                ushort.TryParse(Console.ReadLine(), out day);
                if (day < 1 || day > 365 + dayAdd)
                {
                    Console.Write("n не может принимать данное значение. Попробуй снова: ");
                }
                else
                {
                    int numMounth = 0;
                    while (day > dayMonths[numMounth])
                    {
                        day -= dayMonths[numMounth];
                        numMounth++;
                    }
                    Console.WriteLine($"Current date: {day}{(Mounth)numMounth}");
                    flag = false;
                }

            }

            Console.ReadKey();
        }
    }
}
