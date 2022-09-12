using System;
using System.Collections.Generic;

namespace LessonsSimpleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Цикл 1 итерация №: " + i);
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("\tЦикл 2 итерация №: " + j);
                }
            }
            Console.WriteLine("Some changes for revert operation");
            Console.WriteLine("Some changes for local commit");
        }            
    }
}