using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        //Задача 2.
        //Двумерный массив заполнен случайными натуральными числами от 1 до 10.
        //Найдите количество элементов, значение которых больше 5, и их сумму.
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int [,] array = new int[5,5];
            int countNumber = 0;
            int summNumber = 0;
            int row = array.GetLength(0);
            int colone = array.GetLength(1);

            FillArray(array);
            Console.WriteLine("массив:");
            PrintArray(array);
            SummAndCountArray(array);

            Console.ReadKey();

            void FillArray(int[,] arr)
            {
                for (int i = 0; i < row; i++)
                    for (int j = 0; j < colone; j++)
                        array[i,j] = rnd.Next(1, 11);

            }
            void PrintArray(int[,] arr)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < colone; j++)
                        Console.Write($"{array[i, j],3} |");
                    Console.WriteLine();
                }
            }

            void SummAndCountArray(int[,] arr)
            {
                for (int i = 0; i < row; i++)
                    for (int j = 0; j < colone; j++)
                        if (array[i, j] > 5)
                        {
                            countNumber++;
                            summNumber += array[i, j];
                        }
                Console.WriteLine($"кол-во элементов больше 5 ={countNumber}, их сумма = {summNumber}");


            }

        }
    }
}
