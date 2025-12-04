using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzles.timus
{
    /// <summary>
    /// 2111. Платон
    /// https://acm.timus.ru/problem.aspx?space=1&num=2111
    /// </summary>
    internal class _2111
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var items = Console.ReadLine()
                .Split()
                .Select(UInt64.Parse)
                .OrderByDescending(o => o)
                .ToList();

            var sum = items.Aggregate((x, y) => x + y);

            UInt64 result = 0;

            foreach(var item in items)
            {
                result += (sum * item);
                sum -= item;
                result += (sum * item);
            }


            Console.WriteLine(result);
        }
    }
}
