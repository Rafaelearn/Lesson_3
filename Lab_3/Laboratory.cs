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
            Console.Write("Введите год: ");
            ushort dayAdd = Convert.ToUInt16(Console.ReadLine());
            dayAdd =  (ushort)(dayAdd % 400 == 0 || dayAdd % 4 == 0 && !(dayAdd % 100 == 0) ? 1 : 0);
            if(dayAdd == 1)
            {
                Console.WriteLine("Введенный год високосный");
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
                    Console.WriteLine("Current date: ");
                    if (day <= 31) { Console.Write($"{day} { (Mounth)1}"); }
                    else if (day <= 59 + dayAdd) { Console.Write($"{day - 31} { (Mounth)2}"); }
                    else if (day <= 90 + dayAdd) {Console.Write($"{day- 59 -dayAdd} { (Mounth)3}"); }
                    else if (day <= 120 + dayAdd) { Console.Write($"{day - 90 - dayAdd} { (Mounth)4}"); }
                    else if (day <= 151 + dayAdd) { Console.Write($"{day - 120 - dayAdd} { (Mounth)5}"); }
                    else if (day <= 181 + dayAdd) { Console.Write($"{day - 121 - dayAdd} { (Mounth)6}"); }
                    else if (day <= 212 + dayAdd) { Console.Write($"{day - 181 - dayAdd} { (Mounth)7}"); }
                    else if (day <= 243 + dayAdd) { Console.Write($"{day - 212 - dayAdd} { (Mounth)8}"); }
                    else if (day <= 273 + dayAdd) { Console.Write($"{day - 243 - dayAdd} { (Mounth)9}"); }
                    else if (day <= 304 + dayAdd) { Console.Write($"{day - 273 - dayAdd} { (Mounth)10}"); }
                    else if (day <= 334 + dayAdd) { Console.Write($"{day - 304 - dayAdd} { (Mounth)11}"); }
                    else if (day <= 365 + dayAdd) { Console.Write($"{day - 334 - dayAdd} { (Mounth)12}"); }
                    flag = false;
                }

            }

            Console.ReadKey();
        }
    }
}
