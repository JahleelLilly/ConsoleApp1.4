﻿using System.Runtime.InteropServices;

namespace Assignment1._4
{
    internal struct Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point();

            if (point1.x == point2.x)
            {
                Console.WriteLine("Point not on same axis");
            }
            else
            {
                Console.WriteLine("Point not on same axis");
            }
        }

    }
    public struct Point
    {
        public double x;
        public double y;


    }


}
