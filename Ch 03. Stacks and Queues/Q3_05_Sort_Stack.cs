using System;
using System.Collections.Generic;
using System.Text;

namespace Ch_03._Stacks_and_Queues
{
    class Q3_05_Sort_Stack
    {
        public void Sort(Stack<int> s)
        {
            Stack<int> r = new Stack<int>();

            while(r.Count != 0)
            {
                int temp = s.Pop();
                while(r.Count != 0 && r.Peek() > temp)
                {
                    s.Push(r.Pop());
                }

                r.Push(temp);
            }

            // copy the elements from r back into s
            while(r.Count != 0)
            {
                s.Push(r.Pop());
            }
        }
    }
}
