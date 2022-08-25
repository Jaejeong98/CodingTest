using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 부르트포스
{
    class n_2231
    {
        static void _Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), answer=0;
            for(int i=n; i>0; i--)
            {
				int sum = 0;
				string st=i.ToString();
				for(int j=0; j<st.Length; j++)
					sum += st[j] - '0';
				if (sum + i == n)
					answer = i;
            }
			Console.WriteLine(answer);
        }
    }
}