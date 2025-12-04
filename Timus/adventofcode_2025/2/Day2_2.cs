using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus.adventofcode._2
{
    internal class Day2_2
    {
        public void Main()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "adventofcode_2025/2/input.txt");
            // string filePath = Path.Combine(Directory.GetCurrentDirectory(), "adventofcode_2025/2/test.txt");

            var content = File.ReadAllText(filePath);

            HashSet<Int64> invalidNumbers = new() { };


            foreach (var item in content.Split(","))
            {
                var intevalStr = item.Split(("-"));
                Int64 left = Int64.Parse(intevalStr[0]);
                Int64 right = Int64.Parse(intevalStr[1]);

                for (Int64 i = left; i <= right; i++)
                {
                    if (IsInvalidID(i))
                        invalidNumbers.Add(i);
                }
            }

            Int64 result = 0;
            foreach (var number in invalidNumbers)
            {
                result = result + number;
            }

            Console.WriteLine(result); // 11323661261
        }

        private static bool IsInvalidID(Int64 id)
        {
            var str = id.ToString();

            for (int k = 1; k < str.Length; k++)
            {
                if (IsInvalidID(id, k))
                    return true;
            }

            return false;
        }

        private static bool IsInvalidID(Int64 id, int k)
        {
            var str = id.ToString();

            if (str.Length % k != 0)
                return false;

            int itemsCount = str.Length / k;

            for (int i = 0; i < k; i++)
            {
                char ch = str[i];

                for (int item = 0; item < itemsCount; item++)
                {
                    if (str[i + item * k] != ch)
                        return false;
                }
            }


            return true;
        }
    }
}
