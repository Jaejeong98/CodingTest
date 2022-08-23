using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 재귀
{
    class n_2447
    {
        static char[,] arr;
        static void func(int n, int width, int height)
        {
            if (n == 1)
            {
                arr[width, height] = '*';
                return;
            }
            n /= 3;
            for (int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    if (i == 1 && j == 1)
                        continue;
                    func(n, i * n + width, j * n + height);
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            arr = new char[n, n];
            for (int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                    arr[i, j] = ' ';
            }
            func(n, 0,0);
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                    sb.Append(arr[i,j]);
                sb.Append("\n");
            }
            Console.WriteLine(sb);
        }
    }
}
