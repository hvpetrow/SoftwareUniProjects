﻿using System;

namespace CustomRandomList
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");

            list.RandomString();

            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
