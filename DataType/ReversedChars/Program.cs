﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReversedChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first=char.Parse(Console.ReadLine());
            char second=char.Parse(Console.ReadLine()); 
            char third=char.Parse(Console.ReadLine());
            Console.WriteLine($"{third} {second} {first}");
        }
    }
}
