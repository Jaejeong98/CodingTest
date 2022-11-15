using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이분탐색
{
    class n_1920_20221115
    {
        public static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int M = int.Parse(Console.ReadLine());
            int[] B = Console.ReadLine().Split().Select(int.Parse).ToArray();
            StringBuilder sb = new StringBuilder();
            Array.Sort(A);
            for(int i=0; i<M; i++)
            {
                bool isTrue = false;
                int s = -1, e = n;
                while (e-s>1)
                {
                    int mid = (s + e) / 2;
                    if (A[mid] == B[i])
                    {
                        isTrue = true;
                        break;
                    }
                    else if (A[mid] > B[i])
                        e = mid;
                    else
                        s = mid;
                }
                sb.AppendLine(isTrue ? "1" : "0");
            }
            Console.Write(sb);
        }
    }
}
