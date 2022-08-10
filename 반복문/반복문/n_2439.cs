using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 반복문
{
    class n_2439
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n=int.Parse(Console.ReadLine()), n_copy=n-1;
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if (n_copy <= j)
                        sb.Append("*");
                    else
                        sb.Append(" ");
                }
                n_copy--;
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
    }
}
