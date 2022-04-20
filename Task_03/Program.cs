using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        //Задача 3.
        //Напишите рекурсивный метод, который принимает номер года и определяет, является ли он високосным или нет.
        static void Main(string[] args)
        {
            int numberYear = 1700;
            Boolean flagLeap = false;

            LeapYear(numberYear);
            if (flagLeap) 
                Console.WriteLine($"Год {numberYear}- високосный");
            else 
                Console.WriteLine($"Год {numberYear}- обычный");
            Console.ReadKey();

            Boolean LeapYear(int numm, int div = 100)            
            {
                if (div == 4) return (flagLeap = (numm % div) == 0);

                if (numm % div == 0) 
                    LeapYear(numm/100, 4);
                else 
                    LeapYear(numm, 4);

                return flagLeap;

            }
        }
    }
}
