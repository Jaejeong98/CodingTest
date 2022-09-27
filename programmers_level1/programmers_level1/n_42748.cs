using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmers_level1
{
    class n_42748
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];
            for (int i = 0; i < commands.GetLength(0); i++)
            {
                int[] arr = new int[commands[i, 1] - commands[i, 0] + 1];
                Array.Copy(array, commands[i, 0] - 1, arr, 0, arr.Length);
                Array.Sort(arr);
                answer[i] = arr[commands[i, 2] - 1];
            }
            return answer;
        }
        /*public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];
            for (int i = 0; i < commands.GetLength(0); i++)
            {
                int[] arr = new int[commands[i, 1] - commands[i, 0] + 1];
                int k = 0;
                for (int j = commands[i, 0] - 1; j < commands[i, 1]; j++)
                {
                    arr[k] = array[j];
                    k++;
                }
                Array.Sort(arr);
                answer[i] = arr[commands[i, 2] - 1];
            }
            return answer;
        }*/
    }
}
