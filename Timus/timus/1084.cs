using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzles.timus
{
    /// <summary>
    /// 1084. Пусти козла в огород
    /// https://acm.timus.ru/problem.aspx?space=1&num=1084
    /// </summary>
    internal class _1084
    {
        public static void Main()
        {
            var items = Console.ReadLine().Split();

            double L = int.Parse(items[0]);
            double R = int.Parse(items[1]);

            double S = 0;

            if (2 * R <= L)
            {
                S = Math.PI * R * R;
            }
            else if (R <= (L / 2.0) * Math.Sqrt(2.0))
            {
                double a = Math.Acos((L / 2.0) / R);
                double b = Math.PI / 2.0 - 2 * a;
                double s1 = (Math.Sin(a) * R * L / 2.0) / 2.0;

                double s0 = R * R * b / 2.0;

                S = 4 * (s1 + s1 + s0);
            }
            else
            {
                S = L * L;
            }

            Console.WriteLine(S.ToString("F3"));
        }
    }
}
