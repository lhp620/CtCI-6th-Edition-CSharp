using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter8
{
    class LRU_Cache
    {
        private class Node
        {
            public Node prev;
            public Node next;
            public int key;
            public int value;

            public Node (int key, int value)
            {
                this.key = key;
                this.value = value;
                this.prev = null;
                this.next = null;
            }
        }

        private int capacity;
        private Dictionary<int, Node> hs = new Dictionary<int, Node>();
        private Node head = new Node(-1, -1);
        private Node tail = new Node(-1, -1);

        public LRU_Cache(int capacity)
        {
            this.capacity = capacity;
            tail.prev = head;
            head.next = tail;
        }

        public int Get(int key)
        {
            if (!hs.ContainsKey(key))
            {
                return -1;
            }

            // remove current
            Node current = hs[key];
            current.prev.next = current.next;
            current.next.prev = current.prev;

            // move current to tail
            Move_to_Tail(current);

            return hs[key].value;
        }

        public void Set(int key, int value)
        {
            if (Get(key) != -1)
            {
                hs[key].value = value;
                return;
            }

            if (hs.Count == capacity)
            {
                hs.Remove(head.next.key);
                head.next = head.next.next;
                head.next.prev = head;
            }

            Node insert = new Node(key, value);
            hs[key] = insert;
            Move_to_Tail(insert);
        }

        private void Move_to_Tail(Node current)
        {
            current.prev = tail.prev;
            tail.prev = current;
            current.prev.next = current;
            current.next = tail;
        }

    }
}
