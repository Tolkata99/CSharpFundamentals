﻿using System;

namespace animaType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            switch (animal)
            {


                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "snake":
                case "tortoise":

                    Console.WriteLine("reptile");
                        break;
                default:
                    Console.WriteLine("unknown");
                    break;


            }
        }
    }
}