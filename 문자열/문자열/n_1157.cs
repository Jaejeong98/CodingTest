using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자열
{
    class n_1157
    {
        static void Main(string[] args)
        {
            int[] arr = new int[26];
            string s=Console.ReadLine().ToUpper();
            for(int i=0; i<s.Length; i++)
                arr[(int)s[i] - 65]++;
            int max_i = 0, max=0;
            bool b = false;
            for(int i=0; i<26; i++)
            {
                if (arr[i] > max)
                {
                    max_i = i;
                    max = arr[i];
                    b = false;
                }
                else if (arr[i] == max)
                    b = true;
            }
            Console.WriteLine(b ? "?" : (char)(max_i + 'A'));
        }
    }
}