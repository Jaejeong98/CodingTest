using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 정렬
{
    class n_2750
    {
        static void _Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0; i<n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Array.Sort(arr);
            foreach(int i in arr)
                Console.WriteLine(i);
        }
    }
}
