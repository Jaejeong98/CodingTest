//using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace 정수론_및_조합론
{
    class n_2981
    {
        static List<int> list = new List<int>();
        static int gcd(int n, int m)
        {
            if (m == 0)
                return n;
            else
                return gcd(m, n % m);
        }
        static void func(int n)
        {
            for(int i=1; i<=MathF.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    list.Add(i);
                    if (n / i != i)
                        list.Add(n / i);
                }
            }
        }
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine()), gcd_n=0;
            int[] arr = new int[T], arr2=new int[T-1];
            for(int i=0; i<T; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Array.Sort(arr);
            for (int i = 0; i < T - 1; i++)
            {
                arr2[i] = arr[i + 1] - arr[i];
                gcd_n=gcd(arr2[i], gcd_n);
            }
            func(gcd_n);
            StringBuilder sb = new StringBuilder();
            list.Sort();
            for (int i = 1; i < list.Count; i++)
                sb.Append(list[i]+" ");
            Console.WriteLine(sb);
        }
    }
}