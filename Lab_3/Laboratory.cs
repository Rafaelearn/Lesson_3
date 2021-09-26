using System;
namespace Lab_3
{
    enum Mounth
    {
        January = 1,
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
            bool flag = true;
            var date = new DateTime(1, 12, 31);
            ushort day;
            ushort year;
            Console.Write("Введите порядковый номер дня в текущем году n(1 <= n <= 365): ");
            while (flag)
            {
                ushort.TryParse(Console.ReadLine(), out day);
                if (day<1 || day>365)
                {
                    Console.Write("n не принадлежит указанному промежутку. Попробуй снова: ");
                }
                else
                {
                    Console.Write("Введите год: ");
                    ushort.TryParse(Console.ReadLine(), out year);
                    date = date.AddYears(year-1);
                    date = date.AddDays(day);
                    Console.WriteLine($"Current date: {date.Day} {(Mounth)date.Month}");
                    flag = false;
                }

            }

            Console.ReadKey();
        }
    }
}
