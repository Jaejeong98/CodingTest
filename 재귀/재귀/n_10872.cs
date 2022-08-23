using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 재귀
{
    class n_10872
    {
        static int func(int n)
        {
            if (n <= 1)
                return 1;
            return func(n - 1) * n;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Console.Write(func(N));
        }
    }
}
