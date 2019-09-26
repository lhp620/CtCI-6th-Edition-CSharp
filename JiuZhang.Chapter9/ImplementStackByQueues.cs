using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter9
{
    class ImplementStackByQueues
    {
        public Queue q1 = new Queue();
        public Queue q2 = new Queue();
        //Just enqueue the new element to q1  
        public void Push(int x) => q1.Enqueue(x);

        //move all elements from q1 to q2 except the rear of q1.  
        //Store the rear of q1  
        //swap q1 and q2  
        //return the stored result  
        public int Pop()
        {
            if (q1.Count == 0)
                return -1;
            while (q1.Count > 1)
            {
                q2.Enqueue(q1.Dequeue());
            }
            int res = (int)q1.Dequeue();
            Queue temp = q1;
            q1 = q2;
            q2 = temp;
            return res;
        }

        public int Size() => q1.Count;

        public int Top()
        {
            if (q1.Count == 0)
                return -1;
            while (q1.Count > 1)
            {
                q2.Enqueue(q1.Dequeue());
            }
            int res = (int)q1.Dequeue();
            q2.Enqueue(res);
            Queue temp = q1;
            q1 = q2;
            q2 = temp;
            return res;
        }
    }
}

