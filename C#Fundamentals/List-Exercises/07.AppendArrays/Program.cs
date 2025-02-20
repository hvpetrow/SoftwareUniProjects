﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine()
                .Split("|")
                .ToArray();

            List<string> list = new List<string>();

            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                string[] elements = arrays[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                list.AddRange(elements);
            }
            Console.WriteLine(string.Join(" " , list));

        }
    }
}
