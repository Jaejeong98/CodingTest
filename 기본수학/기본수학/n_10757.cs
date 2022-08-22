using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace 기본수학
{
    class n_10757
    {
        static void Main(string[] args)
        {
            /*string[] str = Console.ReadLine().Split();
            BigInteger n1 = BigInteger.Parse(str[0]), n2 = BigInteger.Parse(str[1]);
            Console.WriteLine(n1 + n2);*/
            string[] str = Console.ReadLine().Split();
            char[] arr1 = (str[0]).ToArray(), arr2 = str[1].ToArray();
            int max = Math.Max(arr1.Length, arr2.Length), min = Math.Min(arr1.Length, arr2.Length), num = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < max; i++)
            {
                if (max - i > arr1.Length)
                    list.Add(arr2[i] - '0');
                else if (max - i > arr2.Length)
                    list.Add(arr1[i] - '0');
                else
                {
                    if (min == arr1.Length)
                        list.Add(arr1[i-(max-min)] - '0' + arr2[i] - '0');
                    else
                        list.Add(arr1[i] - '0' + arr2[i - (max - min)] - '0');
                }
            }
            for (int i=list.Count-1; i>=0; i--)
            {
                if (list[i] >= 10)
                {
                    if (i-1 < 0)
                        num = list[i]/10;
                    else
                        list[i - 1] += (list[i]/10);
                    list[i] %= 10;
                }
            }
            if (num!=0) Console.Write(1);
            for (int i = 0; i < list.Count; i++)
                Console.Write(list[i]);
        }
    }
}
