using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1차원_배열
{
    class n_10818
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(num);
            Console.WriteLine(num[0] + " " + num[n - 1]);
        }
    }
}
