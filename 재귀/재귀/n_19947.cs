using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 재귀
{
    class n_19947
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] num = new int[11];
            num[0] = arr[0];
            for(int i=1; i<11; i++)
            {
                num[i] = (int)(num[i - 1] * 1.05);
                if (i >= 3)
                    num[i] = Math.Max((int)(num[i - 3] * 1.2), num[i]);
                if (i >= 5)
                    num[i] = Math.Max((int)(num[i - 5] * 1.35), num[i]);
            }
            Console.WriteLine(num[arr[1]]);
        }
    }
}