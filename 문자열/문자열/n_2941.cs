using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문자열
{
    class n_2941
    {
        static void Main(string[] args)
        {
            string[] s = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
            string st = Console.ReadLine();
            for(int i= 0; i < s.Length; i++)
                st=st.Replace(s[i], "_");
            Console.WriteLine(st.Length);
        }
    }
}
