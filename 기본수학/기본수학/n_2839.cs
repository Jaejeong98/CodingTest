using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 기본수학
{
    class n_2839
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), answer=0;
            bool b = false;
            while (n >0)
            {
                if (n % 5 == 0)
                {
                    answer += n / 5;
                    b = true;
                    break;
                }
                else
                {
                    n -= 3;
                    answer++;
                }
                if (n == 0)
                    b = true;
            }
            Console.WriteLine(b ? answer : -1);
        }
    }
}
