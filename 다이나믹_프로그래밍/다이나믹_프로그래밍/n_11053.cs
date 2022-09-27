using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 다이나믹_프로그래밍
{
    class n_11053
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] answer = new int[n];
            Array.Fill(answer, 1);
            for(int i=1; i<n; i++)
            {
                for(int j=i-1; j>=0; j--)
                {
                    if (arr[i] > arr[j] && answer[i] <= answer[j])
                        answer[i] = answer[j]+1;
                }
            }
            Array.Sort(answer);
            Console.Write(answer[n - 1]);
        }
    }
}
