using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmers_level2
{
    class n_42586
    {
        public int[] solution(int[] progresses, int[] speeds)
        {
            int[] arr = new int[progresses.Length];
            for (int i = 0; i < progresses.Length; i++)
                arr[i] = (int)MathF.Ceiling((float)(100 - progresses[i]) / speeds[i]);
            List<int> list = new List<int>();
            int count = 1, max = arr[0];
            for (int i = 1; i < progresses.Length; i++)
            {
                if (arr[i] <= max)
                    count++;
                else
                {
                    max = arr[i];
                    list.Add(count);
                    count = 1;
                }
            }
            list.Add(count);
            return list.ToArray();
        }
    }
}
