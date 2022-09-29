using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 그래프이론
{
    class n_9372
    {
        public static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            for(int i=0; i< testCase; i++)
            {
                int[] arr=Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int j=0; j < arr[1]; j++)
                {
                    Console.ReadLine();
                }
                Console.WriteLine(arr[0]-1);
            }
        }
    }
}
