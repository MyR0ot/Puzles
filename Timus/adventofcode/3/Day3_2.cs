using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus.adventofcode._3
{
    internal class Day3_2
    {
        public void Main()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "adventofcode/3/input.txt");
            //string filePath = Path.Combine(Directory.GetCurrentDirectory(), "adventofcode/3/test.txt");

            var lines = File.ReadAllLines(filePath);
            UInt128 result = 0;

            foreach (var line in lines)
            {
                result += GetMaxRating(line);
            }

            Console.WriteLine(result); // 171990312704598
        }

        public static UInt128 GetMaxRating(string str)
        {
            List<int> numbers = str.Select(ch => int.Parse(ch.ToString())).Reverse().ToList();

            List<int> result = new List<int>();
            int curMaxIndex = numbers.Count;

            for (int p = 12; p >= 1; p--)
            {
                int curMax = -1;
                int oldCurMaxIndex = curMaxIndex;
                for (int i = p - 1; i < oldCurMaxIndex; i++)
                {
                    if (numbers[i] >= curMax)
                    {
                        curMax = numbers[i];
                        curMaxIndex = i;
                    }
                }

                result.Add(curMax);
            }

            UInt128 resultNumber = UInt128.Parse(string.Concat(result));

            return resultNumber;
        }
    }
}
