//using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace 정렬
{
    class n_1755
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] Nums = { "zero","one","two","three","four","five","six","seven","eight","nine" };
            Dictionary<string, int> dic = new Dictionary<string, int>();
            StringBuilder sb = new StringBuilder();
            for(int i = arr[0]; i <= arr[1]; i++)
            {
                string st = "", num=i.ToString();
                for(int j=0; j<num.Length; j++)
                    st += Nums[num[j]-'0'];
                dic.Add(st, i);
            }
            int count = 0;
            foreach(var item in dic.OrderBy(i => i.Key))
            {
                if (count != 0 && count % 10 == 0)
                    sb.AppendLine();
                sb.Append(item.Value+" ");
                count++;
            }
            Console.WriteLine(sb);
        }
    }
}
