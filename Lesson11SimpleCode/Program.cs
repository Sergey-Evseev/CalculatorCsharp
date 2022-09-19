using System;
using System.Collections.Generic;

namespace LessonsSimpleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника");
            int height = int.Parse(Console.ReadLine());                     
            //введенный параметр опеределяет количество строк

            for (int i = 0; i <= height; i++) //перебор по строкам
            {
               Console.WriteLine(); //каждую строку начинаем с начала
                               
                for (int k = height; k > i; k--)
                { 
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                { 
                    Console.Write("* ");
                }

            }
            Console.WriteLine();
        }        
    }
}