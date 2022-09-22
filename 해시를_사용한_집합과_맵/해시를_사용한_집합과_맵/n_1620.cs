using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 해시를_사용한_집합과_맵
{
    class n_1620
    {
        static void Main(string[] args)
        {
            int[] arr=Console.ReadLine().Split().Select(int.Parse).ToArray();
            Dictionary<string, string> dic = new Dictionary<string, string>();
			for (int i = 0; i < arr[0]; i++)
			{
				string name = Console.ReadLine();
				dic.Add((i + 1).ToString(), name);
				dic.Add(name, (i + 1).ToString());
			}
			StringBuilder sb = new StringBuilder();
            for(int i=0; i < arr[1]; i++)
            {
				string n = Console.ReadLine();
				sb.Append(dic[n]+"\n");
            }
			Console.WriteLine(sb);
        }
    }
}