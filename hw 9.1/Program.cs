using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1. Задайте значение N.Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.Выполнить с помощью рекурсии.
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            ShowNums(n);
            Console.ReadKey();
        }

        static void ShowNums(int num)
        {
            Console.Write(num + " ");
            if (num > 1) ShowNums(num - 1);
        }
    }
}
