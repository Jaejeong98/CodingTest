using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 재귀
{
    class n_10870
    {
        static int func(int n)
        {
            if (n <= 1)
                return n;
            return func(n - 1) + func(n - 2);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(func(n));
        }
    }
}
