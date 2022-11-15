using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 구현
{
    class n_1913
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()), M= int.Parse(Console.ReadLine());
            int[,] arr = new int[N, N];
            int i = N/2, j = N/2, c=1, num = 1;
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                for (int k = 0; k < c; k++)
                {
                    arr[i,j] = num++;
                    i--;
                }
                if ((num - 1) == N * N) break;
                for (int k = 0; k < c; k++)
                {
                    arr[i, j] = num++;
                    j++;
                }
                c++;
                for (int k = 0; k < c; k++)
                {
                    arr[i, j] = num++;
                    i++;
                }
                for (int k = 0; k < c; k++)
                {
                    arr[i, j] = num++;
                    j--;
                }
                c++;
            }
            for (int k = 0; k < N; k++)
            {
                for (int l=0; l<N; l++)
                {
                    if (arr[k, l] == M)
                    {
                        i = k + 1; 
                        j = l + 1;
                    }
                    sb.Append(arr[k, l]+" ");
                }
                sb.AppendLine();
            }
            Console.Write(sb);
            Console.Write(i + " " +j);
        }
    }
}