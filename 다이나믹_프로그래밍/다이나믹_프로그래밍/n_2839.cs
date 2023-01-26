using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 다이나믹_프로그래밍
{
    class n_2839
    {
        public static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int min = 0;
            while (true)
            {
                if (n <= 0)
                {
                    Console.WriteLine(n == 0 ? min : -1);
                    return;
                }
                else if (n % 5 == 0)
                {
                    min += n / 5;
                    n %= 5;
                }
                else
                {
                    n -= 3;
                    min++;
                }
            }
        }
    }
}
