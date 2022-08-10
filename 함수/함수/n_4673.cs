using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 함수
{
    class n_4673
    {
        static void _Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            bool[] b = new bool[10100];
            for(int i=1; i<=10000; i++)
            {
                int value = i, num=i;
                while(num > 0)
                {
                    value += num % 10;
                    num /= 10;
                }
                b[value] = true;
            }
            for (int i = 1; i <= 10000; i++) {
                if (!b[i])
                    sb.AppendLine(i.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}