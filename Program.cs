using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определяем число, месяц и год.
            float d, m, g;
            //Определим строковые переменные
            string correct = "Корректная дата";
            string incorrect = "Некорректная дата";
            //Вводим дату
            Console.WriteLine("Введите число: "); d =
                float.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц: "); m =
                float.Parse(Console.ReadLine());
            Console.WriteLine("Введите год: "); g =
                float.Parse(Console.ReadLine());
            //Задаем условия еккорректности
            if (Math.Abs(d) > 31)
                Console.WriteLine(incorrect);
            if (Math.Abs(m) > 12)
                Console.WriteLine(incorrect);
            if(Math.Abs(m) == 2 && Math.Abs(d) <= 29)
                Console.WriteLine(correct);
            if (Math.Abs(m) == 1 || Math.Abs(m) == 3 || Math.Abs(m) == 5 || Math.Abs(m) == 7 || Math.Abs(m) == 8 || Math.Abs(m) == 10 || Math.Abs(m) == 12 && Math.Abs(d) <= 31)
                Console.WriteLine(correct);
            if (Math.Abs(m) == 4 || Math.Abs(m) == 6 || Math.Abs(m) == 9 || Math.Abs(m) == 11 && Math.Abs(d) <= 30)
                Console.WriteLine(correct);
            
        }
    }
}
