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
                               
                for (int k = 0; k < i; k++)
                //в первом цикле ставим 0 пробелов, 
                { //в последующих увеличиваем
                    Console.Write(" ");
                }

                for (int j = height; j > i; j--)
                { //в 1-й строке макс. значение равное высоте, далее уменьшаем
                    Console.Write("*");
                }

            }
            Console.WriteLine();
        }        
    }
}