using System;
using System.Collections.Generic;
using System.Text;

namespace JiuZhang.Chapter3
{
    class Two_Sum_Data_Structure_Design
    {
        private List<int> list = null;
        private Dictionary<int, int> map = null;

        public Two_Sum_Data_Structure_Design()
        {
            this.list = new List<int>();
            map = new Dictionary<int, int>();
        }

        public void Add(int number)
        {
            // add to list 
            list.Add(number);

            // add to dic
            int temp;
            if (map.TryGetValue(number, out temp))
            {
                map[number]++;
            }
            else
            {
                map[number] = 1;
            }
        }

        public Boolean Find(int value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int num1 = list[i];
                int num2 = value - num1;

                // try to find the num2 in dic or another num1 in dic
                int temp;
                if(map.TryGetValue(num2, out temp) || ((num1 == num2) && map[num1] > 1))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
