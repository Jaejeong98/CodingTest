using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1차원_배열
{
    class n_8958
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<n; i++)
            {
                string s = Console.ReadLine();
                int sum = 0, p=1;
                for(int j=0; j<s.Length; j++)
                {
                    if (s[j].Equals('O'))
                    {
                        sum += p;
                        p++;
                    }
                    else
                        p=1;
                }
                sb.AppendLine(sum.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
