using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 큐
{
    class n_1966
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<n; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray(),
                    arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Queue<KeyValuePair<int, int>> q = new Queue<KeyValuePair<int, int>>();
                for(int j=0; j < arr[0]; j++)
                    q.Enqueue(new KeyValuePair<int, int>(j, arr2[j]));
                int count = 0;
                while (true)
                {
                    int max = q.Max(x => x.Value);
                    var deq=q.Dequeue();
                    if (deq.Value == max)
                    {
                        if (deq.Key == arr[1])
                            break;
                        count++;
                        continue;
                    }
                    q.Enqueue(deq);
                }
                sb.AppendLine((count+1).ToString());
            }
            Console.Write(sb);
        }
    }
}
