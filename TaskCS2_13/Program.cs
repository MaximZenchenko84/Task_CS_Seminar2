// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskCS2_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое трехзначное число ");
            int input_number = int.Parse(Console.ReadLine());
            if (input_number < 100)
            { 
                Console.WriteLine("Третьей цифры нет ");
            }
            else 
            {
                int third_digit = ((input_number - (input_number % 100)) / 100) % 10;
                Console.Write("Третья цифра  введенного трехзначного числа равна ");
                Console.WriteLine(third_digit);
            }            
        }
    }
}
