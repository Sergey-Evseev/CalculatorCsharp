using System;
using System.Collections.Generic;
using System.Linq;

namespace LessonsSimpleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите длину массива: ");
            int size = int.Parse(Console.ReadLine());

            int [] myArray = new int[size];

            Console.WriteLine("Введите значения элементов массива");

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Вы ввели массив:");
            foreach (var i in myArray)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();            
        }        
    }
}