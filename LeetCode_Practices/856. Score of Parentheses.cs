using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Practices
{
    class _856
    {
        public int ScoreOfParentheses(string S)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(0);

            foreach (char c in S.ToCharArray())
            {
                if (c == '(')
                {
                    stack.Push(0);
                }
                else
                {
                    int first = stack.Pop();
                    int second = stack.Pop();

                    stack.Push(second + Math.Max(2 * first, 1));
                }
            }

            return stack.Pop();
        }
    }
}
