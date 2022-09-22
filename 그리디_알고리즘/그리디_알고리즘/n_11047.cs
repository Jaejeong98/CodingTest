using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 그리디_알고리즘
{
    class n_11047
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray(), won=new int[arr[0]];
            for(int i=0; i < arr[0]; i++)
                won[i] = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = arr[0]-1; i>= 0; i--)
            {
                if (arr[1] < won[i])
                    continue;
                count += (arr[1] / won[i]);
                arr[1] %= won[i];
                if (arr[1] == 0)
                    break;
            }
            Console.WriteLine(count);
        }
    }
}
