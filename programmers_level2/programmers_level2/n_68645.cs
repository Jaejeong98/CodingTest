using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmers_level2
{
    class n_68645
    {
        public int[] solution(int n)
        {
            int[] answer = new int[n * (n + 1) / 2];
            int[,] arr = new int[n, n];
            int x = -1, y = 0, num = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (i % 3 == 0)
                        x++;
                    else if (i % 3 == 1)
                    {
                        y++;
                    }
                    else
                    {
                        x--;
                        y--;
                    }
                    arr[x, y] = num++;
                }
            }
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    answer[c] = arr[i, j];
                    c++;
                }
            }
            return answer;
        }
    }
}
