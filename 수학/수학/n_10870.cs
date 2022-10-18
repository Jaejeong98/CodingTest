using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 수학
{
    class n_10870
    {
        public static int Recursion(int n)
        {
            return n<2?n: Recursion(n-1)+ Recursion(n-2);
        }
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Recursion(n));
        }
        /*public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n + 1];
            for(int i=0; i<=n; i++)
                arr[i] = i < 2 ? i : arr[i - 1] + arr[i - 2];
            Console.WriteLine(arr[n]);
        }*/
    }
}
