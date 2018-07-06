using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter8
{
    public class Moving_Average_from_Data_Stream
    {
        private Queue<int> que;
        private double sum = 0;
        private int size = 0;

        public Moving_Average_from_Data_Stream(int size)
        {
            que = new Queue<int>();
            this.size = size;
        }

        public double  next(int val)
        {
            sum += val;
            if (que.Count == size)
            {
                sum = sum - que.Dequeue();
            }   

            que.Enqueue(val);
            return sum / que.Count;
        }
    }
}
