using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 정렬
{
    class n_1431
    {
        public static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            string[] st=new string[T];
            for(int i=0; i<T; i++)
                st[i] = Console.ReadLine();
            IEnumerable<string> list = from word in st
                                       orderby word.Length, word.Where(x=>x>='0'&&x<='9').Sum(x=>x-'0'), word
                                       select word;
            foreach(string s in list)
                Console.WriteLine(s);
        }
    }
}
