using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus.adventofcode._4
{
    internal class Day4_1
    {
        public void Main()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "adventofcode/4/input.txt");
            // string filePath = Path.Combine(Directory.GetCurrentDirectory(), "adventofcode/4/test.txt");

            List<List<char>> matrix = new List<List<char>>();

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var newLine = new List<char>();

                foreach (var ch in line)
                {
                    newLine.Add(ch);
                }

                matrix.Add(newLine);
            }


            int result = 0;

            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    if (matrix[i][j] == '@' && HasLess4Neighbours(matrix, i, j))
                        result++;
                }
            }

            Console.WriteLine(result); // 1533
        }

        private static bool HasLess4Neighbours(List<List<char>> matrix, int i, int j)
        {
            int neighboursCount = 0;

            for (int x = i - 1; x <= i + 1; x++)
                for (int y = j - 1; y <= j + 1; y++)
                {
                    if (i == x && j == y)
                        continue;

                    if (x < 0 || x >= matrix.Count || y < 0 || y >= matrix[x].Count)
                        continue;

                    if (matrix[x][y] == '@')
                        neighboursCount++;
                }

            return neighboursCount < 4;
        }

        private static void PrintResult(List<List<char>> matrix)
        {
            foreach (var line in matrix)
            {
                foreach (var el in line)
                {
                    Console.Write(el);
                }

                Console.Write("\n");
            }
        }

        private static void PrintResultToFile(List<List<char>> matrix, string fileName)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            using StreamWriter writer = new(filePath);

            foreach (var line in matrix)
            {
                writer.WriteLine(string.Concat(line));
            }
        }
    }
}
