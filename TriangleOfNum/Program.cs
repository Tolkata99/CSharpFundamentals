﻿using System;

namespace TriangleOfNum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
