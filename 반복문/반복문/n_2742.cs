//using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace 반복문
{
    class n_2742
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = n; i > 0; i--)
                sb.AppendLine(i.ToString());
            Console.WriteLine(sb);
        }
    }
}
