using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 수학
{
    class n_2869
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int answer = 0;
            answer = (arr[2] - arr[1]) / (arr[0] - arr[1]) + ((arr[2] - arr[1]) % (arr[0] - arr[1])==0?0:1);
            Console.WriteLine(answer);
        }
    }
}