﻿using System;

namespace _04.SumofChars.DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse (Console.ReadLine());
                sum += symbol;               
            }

            Console.WriteLine($"The sum equals: {sum}");

        }



    }
}
