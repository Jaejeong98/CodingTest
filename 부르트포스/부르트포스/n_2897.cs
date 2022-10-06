using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 부르트포스
{
    class n_2897
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray(), answer=new int[5];
            char[,] ch = new char[arr[0], arr[1]];
            for(int i=0; i < arr[0]; i++)
            {
                string st = Console.ReadLine();
                for(int j=0; j < arr[1]; j++)
                    ch[i, j] = st[j];
            }
            for(int i=0; i < arr[0]-1; i++)
            {
                for(int j=0; j < arr[1]-1; j++)
                {
                    int count = 0;
                    if (ch[i,j] == '#' || ch[i,j + 1] == '#' || ch[i + 1,j] == '#' || ch[i + 1,j + 1] == '#')
                        continue;
                    if (ch[i,j] == 'X')
                        count++;
                    if (ch[i + 1,j] == 'X')
                        count++;
                    if (ch[i,j + 1] == 'X')
                        count++;
                    if (ch[i + 1,j + 1] == 'X')
                        count++;
                    answer[count]++;
                }
            }
            for(int i=0; i<5; i++)
                Console.WriteLine(answer[i]);
        }
    }
}
