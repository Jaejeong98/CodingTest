//using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace 백트래킹
{
    class n_12033
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                sb.Append("Case #" + (i + 1) + ":");
                int n = int.Parse(Console.ReadLine());
                List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
                List<int> ans = new List<int>();
                while (list.Count > 0)
                {
                    int j = list.Count - 1, k = list[j], c= (int)(k * 0.75);

                    if (func(list,c))
                    {
                        ans.Add(c);
                        list.Remove(c);
                        list.Remove(k);
                    }
                }
                ans.Sort();
                foreach (var o in ans)
                    sb.Append(" " + o);
                sb.Append("\n");
            }
            Console.WriteLine(sb);
        }

        public static bool func(List<int> list, int n)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if(list[i]==n)
                    return true;
            }
            return false;
        } 
    }
}
