using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter9
{
    class Merge_Two_Sorted_Interval_Lists
    {
        public List<Interval> MergeTwoInterval(List<Interval> list1, List<Interval> list2)
        {
            List<Interval> results = new List<Interval>();

            if (list1 == null || list2 == null)
            {
                return results;
            }

            Interval last = null, curt = null;
            int i = 0, j = 0;
            while (i < list1.Count && j < list2.Count)
            {
                if (list1[i].start < list2[j].start)
                {
                    curt = list1[i];
                    i++;
                }
                else
                {
                    curt = list2[j];
                    j++;
                }

                last = Merge(results, last, curt);
            }

            while (i<list1.Count)
            {
                last = Merge(results, last, list1[i]);
                i++;
            }

            while (j < list2.Count)
            {
                last = Merge(results, last, list2[j]);
                j++;
            }

            return results;
        }

        private Interval Merge(List<Interval> results, Interval last, Interval curt)
        {
            if (last == null)
            {
                return curt;
            }

            if (curt.start > last.start)
            {
                results.Add(last);
            }

            last.end = Math.Max(last.end, curt.end);

            return last;
        }
    }
}