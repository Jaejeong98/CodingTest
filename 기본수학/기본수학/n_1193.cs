using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 기본수학
{
    class n_1193
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int T= 1, B = 1;
            bool b = false;
            for(int i=1; i<N; i++)
            {
                if (!b)
                {
                    if (T == 1)
                    {
                        B++;
                        b = true;
                    }
                    else
                    {
                        T--;
                        B++;
                    }
                }
                else
                {
                    if (B == 1)
                    {
                        T++;
                        b = false;
                    }
                    else
                    {
                        B--;
                        T++;
                    }
                }
            }
            Console.WriteLine(T + "/" + B);
        }
    }
}
