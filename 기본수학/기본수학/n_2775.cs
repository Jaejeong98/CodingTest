using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 기본수학
{
    class n_2775
    {
        static void Main(string[] args)
        {
            int T=int.Parse(Console.ReadLine());
            int[,] arr = new int[15, 15];
            for (int j = 0; j <= 14; j++)
            {
                arr[j, 1] = 1;
                arr[0, j] = j;
            }
            for(int j=1; j<=14; j++)
            {
                for(int k=1; k<=14; k++)
                    arr[j, k] = arr[j - 1, k] + arr[j, k - 1];
            }
            for (int i=0; i<T; i++)
            {
                int n1 = int.Parse(Console.ReadLine()), n2 = int.Parse(Console.ReadLine());
                Console.WriteLine(arr[n1, n2]);
            }
        }
    }
}
