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


            for (int i = 0; i <= height; i++) //перебор по строкам
            {
               Console.WriteLine(); //каждую строку начинаем с начала
                
                for (int j = 0; j < i; j++)
                { //в 1-й строке печатаем 1 звездочку, в последней i звездочек
                    Console.Write("* ");
                }                
            }
            Console.WriteLine();
        }        
    }
}

//for (int k = width; k > i; k--)

//{
//    Console.Write(" ");
//}