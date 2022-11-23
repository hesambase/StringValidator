using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringValidator
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            if (s.Length > Math.Pow(10, 4))//constraint
                return false;
                Stack<char> ch = new Stack<char>();
                foreach (var item in s.ToCharArray())
                    if (item == '(')
                        ch.Push(')');
                    else if (item == '[')
                        ch.Push(']');
                    else if (item == '{')
                        ch.Push('}');
                    else if (ch.Count == 0 || ch.Pop() != item)
                        return false;

                return ch.Count == 0;
            
        }
    }
}