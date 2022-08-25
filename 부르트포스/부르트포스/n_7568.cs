using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 부르트포스
{
    class n_7568
    {
        static void _Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
			int[,] arr = new int[n, n];
            for(int i=0; i<n; i++)
            {
				int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
				arr[i, 0] = a[0];
				arr[i, 1] = a[1];
            }
			for(int i=0; i<n; i++)
            {
				int r = 1;
				for(int j=0; j<n; j++)
                {
                    if (i == j)
						continue;
                    else
                    {
                        if(arr[i, 0] < arr[j, 0] && arr[i, 1] < arr[j,1])
                            r++;
                    }
                }
                Console.Write(r + " ");
            }
        }
    }
}