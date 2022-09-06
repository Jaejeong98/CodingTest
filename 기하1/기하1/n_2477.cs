using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 기하1
{
    class n_2477
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine()), max_h=0, max_w=0, h=0, w=0;
            int[] arr = new int[6]; 
            for(int i=0; i<6; i++)
            {
                int[] tmp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                arr[i] = tmp[1];
                if (i % 2 == 0)
                    max_h = Math.Max(max_h, tmp[1]);
                else
                    max_w = Math.Max(max_w, tmp[1]);
            }
            for(int i=0; i<6; i++)
            {
                if (i % 2 == 0 && max_h == (arr[i % 6] + arr[(i + 2) % 6]))
                    w = arr[(i+1) % 6];
                else if (i % 2 == 1 && max_w == arr[i % 6] + arr[(i + 2) % 6])
                    h = arr[(i+1) % 6];
            }
            Console.WriteLine((max_h * max_w - h * w)*n);
        }
    }
}