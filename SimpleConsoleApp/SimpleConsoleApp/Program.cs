﻿using System;

namespace SimpleConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SimpleClass Simple = new SimpleClass();

            Simple.GetUsersName();

            Console.WriteLine("Hello " + Simple.Concat(Simple.FirstName, Simple.LastName));
            Console.ReadLine();

            Simple.GetUsersIntValue();
        }
    }
}