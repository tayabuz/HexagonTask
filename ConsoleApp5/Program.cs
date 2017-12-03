using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(0 , 0);
            Point point2 = new Point(108, 50);
            Hexagon hexagon = new Hexagon(point1, point2);
            Point testPoint = new Point(56, 0);
            Point testPointP1 = new Point(83, 0);
            Point testPointP2 = new Point(25, 0);
            Point testPointP3 = new Point(0, 25);
            Point testPointP4 = new Point(25, 50);
            Point testPointP5 = new Point(83, 50);
            Point testPointP6 = new Point(108, 25);
            Hexagon hex = new Hexagon(testPointP1, testPointP2, testPointP3, testPointP4, testPointP5, testPointP6);
            Console.WriteLine(hexagon.IsPointInside(testPoint));
            Console.WriteLine(hex.IsPointInside(testPoint));
            Console.ReadKey();
        }
    }
}
