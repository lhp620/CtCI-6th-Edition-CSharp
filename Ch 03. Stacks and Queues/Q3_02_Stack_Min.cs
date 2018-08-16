using System;
using System.Collections.Generic;
using System.Text;

namespace Ch_03._Stacks_and_Queues
{
    class Q3_02_Stack_Min
    {
        Stack<int> s1;
        Stack<int> s2;

        public Q3_02_Stack_Min()
        {
            s2 = new Stack<int>();
        }

        public void Push(int value)
        {
            if (value <= Min())
            {
                s2.Push(value);
            }
            s1.Push(value);
        }

        public int Pop()
        {
            int value = s1.Pop();

            if (value == Min())
            {
                s2.Pop();
            }

            return value;
        }

        public int Min()
        {
            if(s2.Count == 0)
            {
                return Int32.MaxValue;
            }
            else
            {
                return s2.Peek();
            }
        }
    }
}
