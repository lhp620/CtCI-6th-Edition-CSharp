using System;
using System.Collections.Generic;
using System.Text;

namespace Ch_03._Stacks_and_Queues
{
    class Q3_04_Queue_Via_Stack
    {
        Stack<int> stackNewest, stackOldest;

        public Q3_04_Queue_Via_Stack()
        {
            stackNewest = new Stack<int>();
            stackOldest = new Stack<int>();
        }

        public int size()
        {
            return stackNewest.Count + stackOldest.Count;
        }

        public void Add(int value)
        {
            // push onto stackNewest
            stackNewest.Push(value);
        }

        public void ShiftStacks()
        {
            if (stackOldest.Count == 0)
            {
                while(stackNewest.Count != 0)
                {
                    stackOldest.Push(stackNewest.Pop());
                }
            }
        }

        public int Peek()
        {
            ShiftStacks();
            return stackOldest.Peek();
        }

        public int Remove()
        {
            ShiftStacks();
            return stackOldest.Pop();
        }
    }
}
