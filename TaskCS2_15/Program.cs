// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным

using System;

namespace TaskCS2_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цифру, обозначающую день недели ");
            int input_dayweek = int.Parse(Console.ReadLine());
            if ( (input_dayweek < 1) || (input_dayweek > 7) )
            {
                Console.WriteLine("Некорректный ввод ");
            }
            else
            {
                if ((input_dayweek == 6) || (input_dayweek == 7))
                { Console.WriteLine("Да"); }
                else { Console.WriteLine("Нет"); }
            }         
        }
    }
}
