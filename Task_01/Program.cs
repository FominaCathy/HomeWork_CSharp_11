using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    //Задача 1.
    //На вход подуются два числа n и m, такие, что n<m.
    //Заполните массив случайными числами из промежутка [n, m].
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double [] array = new double [7];
            int numberN = 5;
            int numberM = 15;

            FillArray(array);   
            PrintArray(array);
            Console.ReadKey();


            void FillArray(double [] arr)
            {
                for (int i = 0; i < array.Length; i++)
                    array[i] = rnd.Next(numberN, numberM) + rnd.NextDouble();

            }
            void PrintArray(double[] arr)
            {
                for (int i = 0; i < array.Length; i++)
                    Console.Write($" {array[i]:f02}; "); 
            }
        }
    }
}
    