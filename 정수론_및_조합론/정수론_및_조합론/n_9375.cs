using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 정수론_및_조합론
{
    class n_9375
    {
        static void _Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                int T = int.Parse(Console.ReadLine());
                Dictionary<string,int> dic = new Dictionary<string,int>();
                for(int j=0; j<T; j++)
                {
                    string[] arr = Console.ReadLine().Split();
                    if (dic.ContainsKey(arr[1]))
                        dic[arr[1]]++;
                    else
                        dic.Add(arr[1],1);
                }
                int answer = 1;
                foreach(KeyValuePair<string,int> pair in dic)
                    answer*=(pair.Value+1);
                Console.WriteLine(answer - 1);
            }
        }
    }
}