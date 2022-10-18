using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 재귀
{
    class n_25501
    {
        public static StringBuilder sb = new StringBuilder();
        public static int recursion(string st,int s, int e, int cnt)
        {
            cnt++;
            if (s >= e) { sb.Append("1 " + cnt+"\n");  return 1; }
            else if (st[s] != st[e]) { sb.Append("0 " + cnt + "\n"); return 0; }
            else return recursion(st, s + 1, e - 1, cnt);
        }public static int isPalindrome(string st, int cnt)
        {
            return recursion(st, 0, st.Length-1, cnt);
        }
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), cnt=0;
            for(int i=0; i<n; i++)
                isPalindrome(Console.ReadLine(), cnt);
            Console.WriteLine(sb);
        }
    }
}
