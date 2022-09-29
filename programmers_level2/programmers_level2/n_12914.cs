using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmers_level2
{
    class n_12914
    {
        public long solution(int n)
        {
            long[] arr = new long[2001];
            arr[1] = 1; arr[2] = 2;
            for (int i = 3; i <= n; i++)
                arr[i] = (arr[i - 1] + arr[i - 2]) % 1234567;
            return arr[n];
        }
    }
}
