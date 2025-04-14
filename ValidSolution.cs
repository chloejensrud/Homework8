// written by Chloe Jensrud
// 4/14/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> matchingPair = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            foreach (char c in s)
            {
                if (matchingPair.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0 || matchingPair[stack.Peek()] != c)
                    {
                        return false;
                    }
                    stack.Pop(); // Pop the matched opening bracket
                }
            }
            return stack.Count == 0;
        }
    }
}
