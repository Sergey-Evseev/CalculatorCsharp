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
                catch (Exception)
                {
                    Console.WriteLine("Введены не цифровые значения, enter продолжить, exit выход");
                    flag = Console.ReadLine();
                    continue; //прерывание дальнейшего кода
                }                            

                Console.WriteLine("Введите операцию над числами: '+' '-' '*' '/' ");

                ConsoleKey consoleKey = Console.ReadKey().Key;

                switch (consoleKey)
                {
                    case ConsoleKey.Multiply:
                        Console.WriteLine("\nВы выбрали умножение");
                        Console.WriteLine("Произведение чисел = " + (firstValue * secondValue));
                        break;
                    case ConsoleKey.Add:
                        Console.WriteLine("\nВы выбрали сложение");
                        Console.WriteLine("Сумма чисел = " + (firstValue + secondValue));
                        break;
                    case ConsoleKey.Subtract:
                        Console.WriteLine("\nВы выбрали вычитание");
                        Console.WriteLine("Разница чисел = " + (firstValue - secondValue));
                        break;
                    case ConsoleKey.Divide:
                        Console.WriteLine("\nВы выбрали деление");
                        if (secondValue == 0) { Console.WriteLine("На ноль делить нельзя!"); }
                        else Console.WriteLine("Частное чисел = " + (firstValue / secondValue));
                        break;
                    default:
                        Console.WriteLine("\nНеизвестное действие");
                        break;
                }
                Console.WriteLine("Нажмите enter для продолжения или введите exit для завершения программы");
                flag = Console.ReadLine();
            }          
        }
    }
}