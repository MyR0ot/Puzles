using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzles.timus
{
    /// <summary>
    /// 1052. Охота на зайцев
    /// </summary>
    public class _1052
    {
        public struct Point
        {
            public int X;
            public int Y;
        }

        public void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>(); ;

            for (int i = 0; i < n; i++)
            {
                var str = Console.ReadLine().Split();

                points.Add(new Point() { X = int.Parse(str[0]), Y = int.Parse(str[1]) });
            }

            var maxRes = 0;

            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                {
                    var res = 2;
                    for (int k = 0; k < n; k++)
                    {
                        if (k == i || k == j)
                        {
                            continue;
                        }

                        if (IsLine(points[i], points[j], points[k]))
                        {
                            res++;
                        }
                    }

                    if (res > maxRes)
                        maxRes = res; ;
                }

            Console.WriteLine(maxRes);

        }

        public static bool IsLine(Point p1, Point p2, Point p3)
        {
            return (p3.Y - p1.Y) * (p2.X - p1.X) == (p2.Y - p1.Y) * (p3.X - p1.X);
        }
    }
}
