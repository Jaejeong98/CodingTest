using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자열
{
    class n_2204
    {
        public static void Main(string[] args)
        {
            int n = 0;
            while ((n = int.Parse(Console.ReadLine())) != 0)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                for(int i=0; i<n; i++)
                {
                    string st = Console.ReadLine();
                    dic.Add(st.ToLower(), st);
                }
                dic=dic.OrderBy(item => item.Key).ToDictionary(x => x.Key, x => x.Value);
                Console.WriteLine(dic.ElementAt(0).Value);
            }
        }
    }
}
