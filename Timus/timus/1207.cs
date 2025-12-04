using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzles.timus
{
    /// <summary>
    /// 1052. Охота на зайцев
    /// https://acm.timus.ru/problem.aspx?space=1&num=1207
    /// </summary>
    internal class _1207
    {
        public struct Point
        {
            public double X;
            public double Y;

            public int Number;
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>(); ;

            for (int i = 0; i < n; i++)
            {
                var str = Console.ReadLine().Split();

                points.Add(new Point() { X = int.Parse(str[0]), Y = int.Parse(str[1]), Number = i + 1 });
            }

            var sortedPoints = points.OrderBy(p => p.X).ThenBy(p => p.Y).ToList();
            var specialPoint = new Point() { X = sortedPoints[0].X, Y = sortedPoints[0].Y + 1, Number = 0 };

            var otherPoints = sortedPoints.Skip(1).OrderBy(p => GetCosA(sortedPoints[0], specialPoint, p)).ToList();



            Console.WriteLine($"{sortedPoints[0].Number} {otherPoints[otherPoints.Count / 2].Number}");
        }

        public static double GetCosA(Point vertex, Point p1, Point p2)
        {
            double scalarPr = (p1.X - vertex.X) * (p2.X - vertex.X) + (p1.Y - vertex.Y) * (p2.Y - vertex.Y);
            return scalarPr / (GetDistance(vertex, p1) * GetDistance(vertex, p2));
        }

        public static double GetDistance(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }

    }
}
