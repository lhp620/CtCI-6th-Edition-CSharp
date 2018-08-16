using ctci.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuZhang.Chapter7
{
    public class CSI_Interview_Questions
    {
        /*
        Question1
        You are given coins of different denominations and a total amount of money amount.
        Write a function to compute the fewest number of coins that you need to make up that amount.
        If that amount of money cannot be made up by any combination of the coins, return -1.
        Example 1:
           coins = [1, 2, 5], amount = 11
           return 3 (11 = 5 + 5 + 1)
        Example 2:
           coins = [2], amount = 3
           return -1.
        Note:
        You may assume that you have an infinite number of each kind of coin.
        */
        // this is a wrong solution
        public static int FindFewestCoins_Wrong(int[] coins, int amount)
        {
            int count = 0;
            Array.Sort(coins);
            for (int i = coins.Length - 1; i >= 0; i--)
            {
                while (coins[i] <= amount)
                {
                    amount -= coins[i];
                    count++;
                }

                if (amount == 0)
                {
                    return count;
                }
            }
            return -1;
        }

        public static int FindFewestCoins(int[] coins, int m, int v)
        {
            //base case
            if (v ==0)
            {
                return 0;
            }

            int result = int.MaxValue;

            for (int i = 0; i < m; i++)
            {
                if (coins[i] <= v)
                {
                    int sub_result = FindFewestCoins(coins, m, v - coins[i]);

                    if (sub_result != int.MaxValue && sub_result + 1 < result)
                    {
                        result = sub_result + 1;
                    }
                }
            }

            return result;
        }

        public static int FindFewestCoins_dynamic(int[] coins, int m, int v)
        {
            int[] table = new int[v + 1];

            table[0] = 0;

            for(int i = 1; i< table.Length; i++)
            {
                table[i] = int.MaxValue;
            }

            for (int i = 1; i <= v; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (coins[j] <= i)
                    {
                        int sub_result = table[i - coins[j]];
                        if (sub_result != int.MaxValue && sub_result + 1 < table[i])
                        {
                            table[i] = sub_result + 1;
                        }
                    }
                }
            }

            return table[v];
        }

        public static int CoinsChanges(int[] coins, int coin_number, int amount)
        {
            // base case
            // if amount == 0, there is a solution: not select anyone
            if (amount == 0)
            {
                return 1;
            }

            // if amount < 0; there is no solution
            if (amount < 0)
            {
                return 0;
            }

            // if there is no coin left, but amount is still has remains values, there is no solution
            if (coin_number <=0 && amount >=1)
            {
                return 0;
            }

            return CoinsChanges(coins, coin_number - 1, amount) + CoinsChanges(coins, coin_number, amount - coins[coin_number - 1]);
        }


        //https://algorithms.tutorialhorizon.com/dynamic-programming-coin-change-problem/
        public static int CoinsChanges_Dynamic(int[] coins, int coin_number, int amount)
        {
            int[] table = new int[amount + 1];

            for (int i = 0; i < table.Length; i++)
            {
                table[i] = 0;
            }

            table[0] = 1;

            for (int i = 0; i < coin_number; i++)
            {
                for(int j = coins[i]; j <= amount; j++)
                {
                    table[j] += table[j - coins[i]];
                }
            }
            
            return table[amount];
        }


        public static void LevelOrderTraversal(TreeNode root)
        {
            List<List<int>> output = new List<List<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode currentNode = queue.Dequeue();
                Console.WriteLine(currentNode.Data);

                if (currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }

        }

        /*
        Questions # 3
         Given an array S of n integers, are there  elements a, b, c in S such that a + b + c = 0? Find all  unique triplets in the array which gives the sum of zero.
         Note: Elements in a triplet (a,b,c) must be in non-descending  order. (ie, a ≤  b ≤ c)
        The solution set must not contain duplicate triplets.
        For example, given array S = {-1 0 1 2 -1 -4},
          A solution set is:
             (-1, 0, 1)
             (-1, -1, 2)

        */

        public static List<int[]> FindTriplets(int[] arr)
        {
            List<int[]> output = new List<int[]>();
            Array.Sort(arr);

            //Let i be static and create j and k to be indicies we move around to find a zero sum.
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i + 1;
                int k = arr.Length - 1;
                while (j < k)
                {
                    int sum = arr[i] + arr[j] + arr[k];
                    if (sum < 0)
                        j++;
                    else if (sum > 0)
                        k--;
                    else
                    {
                        int[] triplet = { arr[i], arr[j], arr[k] };
                        if (!checkDuplicate(output, triplet))
                            output.Add(triplet);
                        j++;
                        k--;
                    }
                }
            }

            return output;
        }

        // Helper function to see if the triplet we want to insert is already in the list or not.
        private static bool checkDuplicate(List<int[]> list, int[] newTrip)
        {
            foreach (int[] triplet in list)
            {
                if (newTrip.SequenceEqual(triplet))
                    return true;
            }

            return false;
        }

    }
}
