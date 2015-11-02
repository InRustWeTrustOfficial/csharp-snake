using System;
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
            int x1 = 3;
            int y1 = 4;
            char symb1 = '$';
            int x2 = 6;
            int y2 = 8;
            char symb2 = '#';

            Draw(x1, y1, symb1);
            Draw(x2, y2, symb2);
            Console.ReadLine();
        }

        static void Draw(int x, int y, char symb)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symb);
        }
    }
}
