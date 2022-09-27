using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 두포인터
{
    class n_1337
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n], answer=new int[n];
            for(int i=0; i<n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Array.Sort(arr);
            for (int j = 0; j < n; j++)
            {
                for (int i = arr[j]; i < arr[j] + 5; i++)
                {
                    if (!arr.Contains(i))
                        answer[j]++;
                }
            }
            Array.Sort(answer);
            Console.WriteLine(answer[0]);
        }
    }
}
