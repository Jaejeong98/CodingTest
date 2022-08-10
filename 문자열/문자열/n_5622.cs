using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자열
{
    class n_5622
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int sum = 0;
            for(int i=0; i<s.Length; i++)
            {
                int num= (int)s[i] - 65;
                if (num > 17)
                    num -= num == 25 ? 2 : 1;
                sum+=num/ 3;
            }
            Console.WriteLine(3*s.Length+sum);
        }
    }
}