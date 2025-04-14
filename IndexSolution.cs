// written by Chloe Jensrud
// 4/14/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPivotIndex
{
    public class Solution
    {
        public int PivotIndex(int[] nums)
        {
            int total = 0; 

            foreach(int num in nums)
            {
                total += num;
            }
            int leftSum = 0; 
            for (int i = 0; i < nums.Length; i++)
            {
                int rightSum = total - leftSum - nums[i];
                if (leftSum == rightSum)
                {
                    return i;
                }
                leftSum += nums[i];
            }
            return -1; 
        }
    }
}
