using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 부르트포스
{
    class n_1436
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), result=0;
            while (n>0)
            {
                result++;
                if (result.ToString().Contains("666"))
                    n--;
            }
            Console.WriteLine(result);
        }
    }
}