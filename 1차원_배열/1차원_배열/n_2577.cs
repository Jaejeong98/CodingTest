using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1차원_배열
{
    class n_2577
    {
        static void Main(string[] args)
        {
            int num = 1;
            for (int i = 0; i < 3; i++)
                num *= int.Parse(Console.ReadLine());
            string num_s=num.ToString();
           int[] arr = new int[10];
            for (int i=0; i< num_s.Length; i++)
                arr[(int)num_s[i]-'0']++;
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
    }
}
