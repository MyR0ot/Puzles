using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus.adventofcode
{
    internal class Day1_1
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

                if (isRigthRotation)
                    curCursorValue += ticks;
                else 
                    curCursorValue -= ticks;
                
                curCursorValue %= 100;

                if (curCursorValue == 0)
                    password++;
            }

            Console.WriteLine(password); // 984
        }

    }
}
