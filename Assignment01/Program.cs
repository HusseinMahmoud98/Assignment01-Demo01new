﻿using Demo01;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
             * Write a C# program that takes two points as input from the user and calculates the distance between them. */
            Point P01 = new Point();
            Point P02 = new Point();

            Console.WriteLine("Enter the coordinate X of the first point P01");
            P01.X = double.Parse(Console.ReadLine());


            P01.Y = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point P02");
            P02.X = double.Parse(Console.ReadLine());
            P02.Y = double.Parse(Console.ReadLine());

            Console.WriteLine($"the disance between P01 and P02 is {Math.Sqrt(Math.Pow(P02.X - P01.X, 2) + Math.Pow(P02.Y - P01.Y, 2))}");




        }
    }
}
