using System;
using System.Collections.Generic;
using System.Linq;


namespace LessonsSimpleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] myArray = new int[5]; // выделение памяти сразу с момент обявления массива

            int [] myArray1 = new int[5] {1, 2, 10, 15, 6 }; // инициализация в момент объявления и выделения памяти

            int[] myArray2 = new int[] { 100, 3, 27, 600 }; // выделение памяти в момент инициализации

            int[] myArray3 = { 100, 3, 27, 600 }; // выделение памяти в момент инициализации
                        

            int[] myArray4 = Enumerable.Repeat(5, 10).ToArray();
            //Repeat<TResult>(TResult, Int32)	
            // Генерирует последовательность, содержащую одно повторяющееся значение.

            int[] myArray5 = Enumerable.Range(98, 15).ToArray();


            foreach (var i in myArray5)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();            
        }        
    }
}