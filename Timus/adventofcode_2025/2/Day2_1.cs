using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Timus.adventofcode._2
{
    internal class Day2_1
    {
        public void Main()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "adventofcode_2025/2/input.txt");
            // string filePath = Path.Combine(Directory.GetCurrentDirectory(), "adventofcode_2025/2/test1.txt");

            var content = File.ReadAllText(filePath);

            HashSet<Int64> invalidNumbers = new() { };


            foreach (var item in content.Split(","))
            {
                var intevalStr = item.Split(("-"));
                Int64 left = Int64.Parse(intevalStr[0]);
                Int64 right = Int64.Parse(intevalStr[1]);

                for(Int64 i = left; i <= right; i++)
                {
                    if (IsInvalidID(i))
                        invalidNumbers.Add(i);
                }
            }

            Int64 result = 0;
            foreach (var number in invalidNumbers)
            {
                result += number;
            }

            Console.WriteLine(result); // 9188031749
        }

        private bool IsInvalidID(Int64 id)
        {
            var str = id.ToString();

            if (str.Length % 2 == 1)
                return false;

            var delta = str.Length / 2;

            for (int i = 0; i < delta; i++)
                if (str[i] != str[i + delta])
                    return false;

            return true;
        }
    }
}
