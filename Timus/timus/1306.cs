using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzles.timus
{
    /// <summary>
    /// https://acm.timus.ru/problem.aspx?space=1&num=1306
    /// 1306. Медиана последовательности
    /// </summary>
    public class _1306
    {
        public void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<ulong> numbers = new List<ulong>(n);
            for (int i = 0; i < n; i++)
            {
                numbers.Add(ulong.Parse(Console.ReadLine()));
            }

            numbers.Sort();

            if (n % 2 == 0)
            {
                double res = (numbers[n / 2] + numbers[n / 2 - 1]) / 2.0;
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine(numbers[n / 2]);
            }

            /*
            int min = numbers[0];
            int max = numbers[0];
            for (int i = 0; i < n; i++) 
            {
                if (numbers[i] > max)
                    max = numbers[i];
                
                if (numbers[i] < min)
                    min = numbers[i];
            }

            int spread = max - min;
            */

        }
    }
    /*
     #include <iostream>
#include <vector>
#include <algorithm>

int main() {
    int n;
    std::cin >> n;
    
    std::vector<unsigned long long> numbers;
    numbers.reserve(n);
    
    for (int i = 0; i < n; i++) {
        unsigned long long num;
        std::cin >> num;
        numbers.push_back(num);
    }
    
    std::sort(numbers.begin(), numbers.end());
    
    if (n % 2 == 0) {
        double res = ((double)numbers[n/2] + (double)numbers[n/2 - 1]) / 2.0;
        std::cout << res << std::endl;
    } else {
        std::cout << numbers[n/2] << std::endl;
    }
    
    return 0;
}
     
     */
}
