﻿using System;
using System.Collections.Generic;

namespace InterfaceIComparableCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle[] circles = new Circle[3];
            circles[0] = new Circle(3.6);
            circles[1] = new Circle();
            circles[2] = new Circle(3.5, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }

            IComparer<Circle> circleComparator = new CircleCompara();
            Array.Sort(circles, circleComparator);

            Console.WriteLine("After-sorted:");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }
        }
    }
}