using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmers_level1
{
    class 시저암호
    {
        public string solution(string s, int n)
        {
            string answer = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                    answer += s[i] + n > 'Z' ? (char)(s[i] - 26 + n) : (char)(s[i] + n);
                else if (Char.IsLower(s[i]))
                    answer += s[i] + n > 'z' ? (char)(s[i] - 26 + n) : (char)(s[i] + n);
                else
                    answer += " ";
            }
            return answer;
        }
    }
}
