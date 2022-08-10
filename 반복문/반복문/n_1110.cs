using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 반복문
{
    class n_1110
    {
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());
            int sum = num, count=0;
            while (true)
            {
                sum = (sum % 10) * 10 + (sum % 10 + sum / 10)%10;
                count++;
                if (sum == num)
                    break;
            }
            Console.WriteLine(count);
        }
    }
}
