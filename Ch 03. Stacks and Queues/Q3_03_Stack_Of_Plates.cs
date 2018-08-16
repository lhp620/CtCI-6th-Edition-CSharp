using System;
using System.Collections.Generic;
using System.Text;

namespace Ch_03._Stacks_and_Queues
{
    class Q3_03_Stack_Of_Plates
    {
        List<Stack<int>> stacks = new List<Stack<int>>();
        public int capacity;

        public Q3_03_Stack_Of_Plates(int capacity)
        {
            this.capacity = capacity;
        }

        public Stack<int> GetLastStack()
        {
            if(stacks.Count == 0)
            {
                return null;
            }

            return stacks[stacks.Count - 1];
        }

        public void Push(int v)
        {
            Stack<int> last = GetLastStack();

            if (last != null && last.Count != capacity)
            {
                last.Push(v);
            }
            else
            {
                // create a new stack
                Stack<int> stack = new Stack<int>();
                stack.Push(v);
                stacks.Add(stack);
            }
        }

        public int Pop()
        {
            Stack<int> last = GetLastStack();
            if (last == null)
            {
                throw new Exception();
            }

            int v = last.Pop();
            if (last.Count ==0)
            {
                stacks.Remove(stacks[stacks.Count - 1]);
            }

            return v;
        }

        public bool IsEmpty()
        {
            Stack<int> last = GetLastStack();

            return last == null || last.Count == 0;
        }

        public int PopAt(int index)
        {
            return LeftShift(index, true);
        }

        private int LeftShift(int index, bool removeTop)
        {
            Stack<int> stack = stacks[index];
            int removed_item;

            if(removeTop)
            {
                removed_item = stack.Pop();
            }
            else
            {
                //removed_item = stack.RemoveBottom();
            }

            if (stack.Count ==0)
            {
                stacks.Remove(stacks[index]);
            }
            else if (stacks.Count > index + 1)
            {
                int v = LeftShift(index + 1, false);
                stack.Push(v);
            }

            //return removed_item;
            return 0;
        }
    }
}
