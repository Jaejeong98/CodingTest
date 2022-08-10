using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 함수
{
    class n_1065
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()),count=0;
            for(int i = 100; i <=n; i++)
            {
                int n1 = i / 100, n2 = i % 100 / 10, n3 = i % 10;
                if (n1 - n2 == n2 - n3)
                    count++;
            }
            Console.WriteLine(count+(n<100?n:99));
        }
    }
}
