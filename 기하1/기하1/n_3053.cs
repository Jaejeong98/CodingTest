using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 기하1
{
    class n_3053
    {
        static void _Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(n*n*Math.PI,6));
            Console.WriteLine(Math.Round(n*n*2,6));
        }
    }
}
