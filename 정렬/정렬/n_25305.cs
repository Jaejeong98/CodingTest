using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 정렬
{
    class n_25305
    {
        static void _Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray(),
                score= Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(score);
            Console.WriteLine(score[num[0] - num[1]]);
        }
    }
}
