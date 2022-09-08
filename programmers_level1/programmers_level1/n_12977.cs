using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmers_level1
{
    class n_12977
    {
        public bool func(int x)
        {
            for (int i = 2; i <= MathF.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public int solution(int[] nums)
        {
            int answer = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int num = nums[i] + nums[j] + nums[k];
                        if (func(num))
                            answer++;
                    }
                }
            }
            return answer;
        }
    }
}
