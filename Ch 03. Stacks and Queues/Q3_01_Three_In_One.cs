using ctci.Contracts;
using System;

namespace Ch_03._Stacks_and_Queues
{
    public class Q3_01_Three_In_One
    {
        private int numbersOfStacks = 3;
        private int stackCapacity;
        private int[] values;
        private int[] sizes;

        public Q3_01_Three_In_One(int stackSize)
        {
            stackCapacity = stackSize;
            values = new int[stackSize * numbersOfStacks];
            sizes = new int[numbersOfStacks];
        }

        //push value onto stack
        public void Push(int stackNum, int value)
        {
            if (IsFull(stackNum))
            {
                throw new Exception();
            }

            // increment stack pointer and then update top value
            sizes[stackNum]++;
            values[IndexOfTop(stackNum)] = value;
        }

        // pop item from top stack
        public int Pop(int stackNum)
        {
            if(IsEmpty(stackNum))
            {
                throw new Exception();
            }

            int topIndex = IndexOfTop(stackNum);
            int value = values[topIndex];

            values[topIndex] = 0;
            sizes[stackNum]--;
            return value;
        }

        // return top element
        public int Peek(int stackNum)
        {
            if(IsEmpty(stackNum))
            {
                throw new Exception();
            }

            return values[IndexOfTop(stackNum)];
        }

        // return if stack is empty
        public bool IsEmpty(int stackNum)
        {
            return sizes[stackNum] == 0;
        }

        // return if stack is full
        public bool IsFull(int stackNum)
        {
            return sizes[stackNum] == stackCapacity;
        }

        // return index of the top of the stack
        public int IndexOfTop(int stackNum)
        {
            int offset = stackNum * stackCapacity;
            int size = sizes[stackNum];
            return offset + size - 1;
        }

        public void Three_In_One()
        {
            
            
        }
    }
}
