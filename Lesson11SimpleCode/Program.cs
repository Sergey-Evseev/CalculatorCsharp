using System;
using System.Collections.Generic;

namespace LessonsSimpleCode
{
    class Program
    {
        static int[,] GetRandomArray(int rows, int columns)
        {
            Random random = new Random();
            var result = new int[rows, columns]; //создаем новый массив интов и присваиваем его переменной
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = random.Next(100);//заполнение массива
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            int rows = 5;
            int columns = 10;
            var myArray = GetRandomArray(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{myArray[i,j]}\t");
                }
            }
        }
        
    }         
}    