using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1차원_배열
{
    class n_1546
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(num);
            double sum = 0;
            for (int i = 0; i < n; i++)
                sum += (double)num[i] / num[n - 1] * 100;
            Console.WriteLine(sum/n);
        }
    }
}
