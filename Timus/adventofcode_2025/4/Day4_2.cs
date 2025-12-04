using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus.adventofcode._4
{
    internal class Day4_2
    {
        public void Main()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "adventofcode_2025/4/input.txt");
            // string filePath = Path.Combine(Directory.GetCurrentDirectory(), "adventofcode_2025/4/test.txt");

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

            while (true)
            {
                var tmp = RemoveItems(matrix);

                if (tmp.RemovedCount == 0)
                    break;

                result += tmp.RemovedCount;
                matrix = tmp.NewMatrix; 
            }

            Console.WriteLine(result); // 9206

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

        private static (List<List<char>> NewMatrix, int RemovedCount) RemoveItems(List<List<char>> matrix)
        {
            int result = 0;
            List<List<char>> resultMatrix = new();
            for (int i = 0; i < matrix.Count; i++)
            {
                var newLine = new List<char>();

                for (int j = 0; j < matrix[i].Count; j++)
                {
                    if (matrix[i][j] == '@' && HasLess4Neighbours(matrix, i, j)) 
                    {
                        result++;
                        newLine.Add('x');
                    }
                    else
                    {
                        newLine.Add(matrix[i][j]);
                    }
                }

                resultMatrix.Add(newLine);
            }


            return (resultMatrix, result);
        }
    }
}
