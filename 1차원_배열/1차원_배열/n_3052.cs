using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1차원_배열
{
    class n_3052
    {
        static void Main(string[] args)
        {
            List<int>list=new List<int>();
            for(int i=0; i<10; i++)
                list.Add(int.Parse(Console.ReadLine()) % 42);
            list=list.Distinct().ToList();
            Console.WriteLine(list.Count);
        }
    }
}
