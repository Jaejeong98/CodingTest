using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 집합과맵
{
    class n_1764
    {
        static void _Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<string> hash = new HashSet<string>();
            List<string> list2 = new List<string>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr[0]; i++)
                hash.Add(Console.ReadLine());
            for(int i=0; i < arr[1]; i++)
            {
                string st = Console.ReadLine();
                if (hash.Contains(st))
                    list2.Add(st);
            }
            list2.Sort();
            sb.Append(list2.Count + "\n");
            foreach (var i in list2)
                sb.Append(i+"\n");
            Console.Write(sb);
        }
    }
}
