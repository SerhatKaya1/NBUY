﻿using Solid02_SingleResponsibility.Before;

namespace Solid02_SingleResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sonuç"+ Actions.Sum(5,15)); 
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}