using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 그리디_알고리즘
{
    class n_1969
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] st = new string[arr[0]];
            string result = "";
            for (int i = 0; i < arr[0]; i++)
                st[i] = Console.ReadLine();
            for(int j=0; j < arr[1]; j++)
            {
                int[] al = new int[26];
                for (int i = 0; i < arr[0]; i++)
                    al[st[i][j] - 'A']++;
                bool b = false;
                for (int i=0; i<26; i++)
                {
                    if (al.Max() == al[i]&&!b)
                    {
                        result += (char)(i+'A');
                        b=true;
                    }
                }
            }
            int cnt = 0;
            for(int i=0; i < arr[0]; i++)
            {
                for(int j=0; j < arr[1]; j++)
                {
                    if (st[i][j] != result[j])
                        cnt++;
                }
            }
            Console.WriteLine(result+"\n"+cnt);
        }
    }
}
