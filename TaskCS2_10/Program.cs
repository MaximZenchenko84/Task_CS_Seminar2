// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа
using System;
//double abs(double a_)
//{
//    return (a_ > 0 ? a_ : -a_);
//}

namespace TaskCS2_10
{
    class TaskCS2_10
    {
        static void Main(string[] args)
        {
            //double abs(double a_)
            //{
            //    return (a_ > 0 ? a_ : -a_);
            //}
            Console.Write("Введите целое трехзначное число a = ");
            int a = int.Parse(Console.ReadLine());
            //if ((abs(a) < 100) || (abs(a) > 999))
            //{ 
            //    Console.WriteLine("Incorrect input");
            //    break;
            //}
            int b;
            b = ((a % 100) - ((a % 100) % 10)) / 10;
            Console.Write("Вторая цифра  введенного трехзначного числа равна ");
            Console.WriteLine(b);
        }
    }
}
