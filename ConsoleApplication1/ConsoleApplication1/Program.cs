﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 4, '$');
            p1.Draw();

            Point p2 = new Point(6, 8, '#');
            p2.Draw();

            Console.ReadLine();
        }

    }
}
