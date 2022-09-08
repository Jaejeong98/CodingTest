using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 정수론_및_조합론
{
    class n_2609
    {
        static int gcd(int n, int m)
        {
            if (m == 0)
                return n;
            else
                return gcd(m, n % m);
        }
        static void _Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int gcd_n = gcd(arr[0], arr[1]);
            Console.WriteLine(gcd_n + "\n" + arr[0] / gcd_n * arr[1]);
        }
    }
}