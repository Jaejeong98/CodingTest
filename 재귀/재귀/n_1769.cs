using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 재귀
{
    class n_1769
    {
        public static int count = 0;
        public static string func(string s)
        {
            if (s.Length == 1)
                return s;
            count++;
            int sum = 0;
            for(int i=0; i<s.Length; i++)
                sum += (s[i]-'0');
            return func(sum.ToString());
        }
        public static void Main(string[] args)
        {
            string st = Console.ReadLine();
            string result = int.Parse(func(st)) % 3 == 0 ? "YES" : "NO";
            Console.WriteLine(count+"\n"+result);
        }
    }
}
