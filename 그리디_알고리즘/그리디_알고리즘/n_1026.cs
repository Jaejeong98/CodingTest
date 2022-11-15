using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 그리디_알고리즘
{
    class n_1026
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> B = Console.ReadLine().Split().Select(int.Parse).ToList();
            Array.Sort(A);
            int sum = 0, i=0;
            while (B.Count > 0)
            {
                sum += B.Max() * A[i];
                B.Remove(B.Max());
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
