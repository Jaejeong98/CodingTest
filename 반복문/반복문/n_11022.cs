using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 반복문
{
    class n_11022
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            StringBuilder sb=new StringBuilder();
            for(int i = 0; i < n; i++)
            {
                int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
                sb.AppendLine($"Case #{i + 1}: {num[0]} + {num[1]} = {(num[0] + num[1])}");
            }
            Console.WriteLine(sb);
        }
    }
}
