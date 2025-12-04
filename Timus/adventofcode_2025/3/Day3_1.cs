using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus.adventofcode._3
{
    internal class Day3_1
    {
        public static void Main()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "adventofcode_2025/3/input.txt");
            // string filePath = Path.Combine(Directory.GetCurrentDirectory(), "adventofcode_2025/3/test.txt");

            var lines = File.ReadAllLines(filePath);
            int result = 0;

            foreach (var line in lines)
            {
                result += GetMaxRating(line);
            }

            Console.WriteLine(result); // 17405
        }

        public static int GetMaxRating(string str)
        {
            List<int> numbers = str.Select(ch => int.Parse(ch.ToString())).ToList();

            int max = 0;

            for (int i = 0; i < numbers.Count; i++)
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    int cur = 10 * int.Parse(numbers[i].ToString()) + int.Parse(numbers[j].ToString());
                    if (cur > max)
                        max = cur;
                }


            return max;
        }
    }
}
