using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 반복문
{
    class n_10871
    {
        static void Main(string[] args)
        {
            int[] num1=Console.ReadLine().Split().Select(int.Parse).ToArray(), 
                num2= Console.ReadLine().Split().Select(int.Parse).ToArray();
            StringBuilder sb=new StringBuilder();
            for(int i=0; i < num1[0]; i++)
            {
                sb.Append(num2[i] < num1[1]? num2[i] + " ":"");
            }
            Console.WriteLine(sb);
        }
    }
}
