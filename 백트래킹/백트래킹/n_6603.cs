using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백트래킹
{
    class n_6603
    {
        public static List<int> list = new List<int>();
        public static StringBuilder sb;
        public static int[] arr;
        public static void func(int n)
        {
            if (list.Count == 6)
            {
                for (int i = 0; i < 6; i++)
                    sb.Append(list[i] + " ");
                sb.Append("\n");
                return;
            }
            for(int i=n; i <=arr[0]; i++)
            {
                if (!list.Contains(arr[i]))
                {
                    list.Add(arr[i]);
                    func(i);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
        public static void Main(string[] args)
        {
            string st = "";
            while ((st = Console.ReadLine()) != "0")
            {
                arr = st.Split().Select(int.Parse).ToArray();
                sb = new StringBuilder();
                func(1);
                Console.WriteLine(sb);
            }
        }
    }
}
