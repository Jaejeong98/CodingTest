//using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace 재귀
{
    class n_11729
    {
        static StringBuilder sb = new StringBuilder();
        static void func(int n,int f, int b, int t)
        {
			if (n == 1)
				sb.Append(f + " "+t + "\n");
            else
            {
				func(n - 1, f, t, b);
				sb.Append(f + " " + t + "\n");
				func(n - 1, b, f, t);
			}
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
			func(num, 1, 2, 3);
			Console.WriteLine(Math.Pow(2,num) - 1);
            Console.WriteLine(sb);
        }
    }
}