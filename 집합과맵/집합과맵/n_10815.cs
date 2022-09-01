using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 집합과맵
{
    class n_10815
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            HashSet<int> hash = Console.ReadLine().Split().Select(int.Parse).ToHashSet();
            int m=int.Parse(Console.ReadLine());
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<m; i++)
                sb.Append((hash.Contains(arr2[i])?1:0)+" ");
            Console.Write(sb);
        }
    }
}