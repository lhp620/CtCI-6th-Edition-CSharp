using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter9
{
    class Reverse_Double_Linked_List
    {
        public class Node
        {
            public int data;
            public Node next, previous;
            public Node(int value)
            {
                this.data = value;
                this.next = this.previous = null;
            }
        }

        public void Reverse(Node head)
        {
            Node temp = null;
            Node current = head;

            while(current != null)
            {
                temp = current.previous;
                current.previous = current.next;
                current.next = temp;
                current = current.previous;
            }

            head = temp.previous;
        }

        public void Push(int new_data, Node head)
        {
            Node new_node = new Node(new_data);

            new_node.previous = null;
            new_node.next = head;

            if (head != null)
            {
                head.previous = new_node;
            }

            head = new_node;
        }
    }
}
