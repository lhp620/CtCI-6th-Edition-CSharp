using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter9
{
    class StackUsingLinkedList
    {
        private class Node
        {
            public int data;
            public Node link;
        }

        Node top;

        public StackUsingLinkedList()
        {
            this.top = null;
        }

        public void Push(int value)
        {
            Node temp = new Node();

            if (temp == null)
            {
                throw new Exception();
            }

            temp.data = value;
            temp.link = top;

            top = temp;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public int peek()
        {
            if (!IsEmpty())
            {
                return top.data;
            }
            else
            {
                throw new Exception();
            }
        }

        public int? Pop()
        {
            if (top == null)
            {
                return null;
            }
            else
            {
                top = top.link;
                return top.data;
            }
        }
    }
}
