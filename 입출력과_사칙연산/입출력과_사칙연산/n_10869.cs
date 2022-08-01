using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 입출력과_사칙연산
{
    class n_10869
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            Console.WriteLine(int.Parse(arr[0]) + int.Parse(arr[1]));
            Console.WriteLine(int.Parse(arr[0]) - int.Parse(arr[1]));
            Console.WriteLine(int.Parse(arr[0]) * int.Parse(arr[1]));
            Console.WriteLine(int.Parse(arr[0]) / int.Parse(arr[1]));
            Console.WriteLine(int.Parse(arr[0]) % int.Parse(arr[1]));
        }
    }
}
