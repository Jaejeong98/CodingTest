using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 정렬
{
    class n_1427
    {
        static void _Main(string[] args)
        {
            char[] arr = Console.ReadLine().ToCharArray();
            Array.Sort(arr);
            for (int t = arr.Length - 1; t >= 0; t--)
                Console.Write(arr[t]);
        }
    }
}
