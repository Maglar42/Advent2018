﻿using System;
using ConsoleApp1.Days;

namespace Advent2018
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Star1: " + new Day5().Star1().ToString());
            Console.WriteLine("Star2: " + new Day5().Star2().ToString());
            Console.ReadLine();
        }
    }
}
