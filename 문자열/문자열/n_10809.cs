using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자열
{
    class n_10809
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string s = Console.ReadLine();
            int[] arr = new int[26];
            Array.Fill(arr,-1);
            for(int i=0; i < s.Length; i++)
            {
                if (arr[s[i] - 97]==-1)
                    arr[s[i] - 97] = i;
            }
            for(int i=0; i<arr.Length; i++)
            {
                sb.Append(arr[i] + " ");
            }
            Console.WriteLine(sb);
        }
    }
}
