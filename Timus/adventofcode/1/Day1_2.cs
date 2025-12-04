using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Timus.adventofcode._2
{
    internal class Day1_2
    {
        public void Main()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "adventofcode/1/input.txt");
            //string filePath = Path.Combine(Directory.GetCurrentDirectory(), "adventofcode/1/test.txt");

            var lines = File.ReadAllLines(filePath);

            int curCursorValue = 50;
            int password = 0;
            

            foreach (var line in lines)
            {
                bool isRigthRotation = line[0] == 'R';
                int ticks = int.Parse(line.Substring(1));

                int oldCursorValue = curCursorValue;
                int fullCirclesCount = ticks / 100;
                int delta = ticks % 100;

                password += fullCirclesCount;

                if (isRigthRotation)
                {
                    curCursorValue = oldCursorValue + delta;
                    if (curCursorValue >= 100 && oldCursorValue != 0)
                        password++;
                }
                else
                {
                    curCursorValue = oldCursorValue - delta;
                    if (curCursorValue <= 0 && oldCursorValue !=0)
                        password++;
                }


                curCursorValue = (curCursorValue + 100) % 100;
            }


            Console.WriteLine(password); // 5657
        }
    }
}
