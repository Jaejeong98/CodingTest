using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 게임이론
{
    class n_20004
    {
        public static void Main(string[] args)
        {
            int input=int.Parse(Console.ReadLine());
            for(int i=1; i<=input; i++)
            {
                if(30%(i+1)==0)
                    Console.WriteLine(i);
            }
        }
    }
}
