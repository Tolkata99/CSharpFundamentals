﻿using System;

namespace _04.SumChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                char currenLetter = char.Parse(Console.ReadLine());
                sum += ((int)currenLetter);
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
