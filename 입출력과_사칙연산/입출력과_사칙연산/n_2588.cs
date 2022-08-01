using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 입출력과_사칙연산
{
    class n_2588
    {
        static void Main(String[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            string n2 = Console.ReadLine();
            for (int i = 0; i < 3; i++)
                Console.WriteLine(int.Parse(n2[2 - i].ToString()) * n1);
            Console.WriteLine(n1 * int.Parse(n2));
        }
    }
}
