using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 부르트포스
{
    class n_2798
    {
        static void _Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = 0, result = 0;
            for(int i=0; i < arr[0]-2; i++)
            {
                for(int j=i+1; j< arr[0]-1; j++)
                {
                    for(int k=j+1; k< arr[0]; k++)
                    {
                        num = arr2[i] + arr2[j] + arr2[k];
                        if (num <= arr[1]&&num>result)
                            result= num;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
