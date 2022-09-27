using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백트래킹
{
    class n_15652
    {
        public static int[] arr = new int[2];
        public static List<int> list = new List<int>();
        public static StringBuilder sb = new StringBuilder();
        public static void dfs(int n)
        {
            if (list.Count == arr[1])
            {
                int count = 0;
                for(int i=0; i<list.Count; i++)
                {
                    sb.Append(list[i] + " ");
                    count++;
                    if (count == arr[1])
                        sb.Append("\n");
                }
                return;
            }
            for(int i=n; i <= arr[0]; i++)
            {
                list.Add(i);
                dfs(i);
                list.RemoveAt(list.Count - 1);
            }
        }
        public static void Main(string[] args)
        {
            arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            dfs(1);
            Console.WriteLine(sb);
        }
    }
}
