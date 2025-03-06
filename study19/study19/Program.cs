using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study18
{
    struct Point
    {
        public int x;
        public int y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[2];

            points[0].x = 10;
            points[0].y = 10;

            points[1].x = 20;
            points[1].y = 20;



            foreach (var point in points)
            {
                Console.WriteLine($"Point: ({point.x},{point.y})");
            }



        }
    }
}