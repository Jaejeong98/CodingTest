using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmers_level1
{
    class n_86491
    {
        public int solution(int[,] sizes)
        {
            int max_h = 0, max_w = 0;
            for (int i = 0; i < sizes.Length / 2; i++)
            {
                int max = Math.Max(sizes[i, 0], sizes[i, 1]), 
                    min = Math.Min(sizes[i, 0], sizes[i, 1]);
                max_h = max_h < max ? max : max_h;
                max_w = max_w < min ? min : max_w;
            }
            return max_h * max_w;
        }
    }
}
