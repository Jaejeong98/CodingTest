using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 기본수학
{
    class n_2292
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()), sum=2, answer=1;
            if (num == 1)
                Console.WriteLine(1);
            else
            {
                while (true)
                {
                    if ((sum += 6 * answer) > num)
                    {
                        Console.WriteLine(answer + 1);
                        break;
                    }
                    answer += 1;
                }
            }
        }
    }
}