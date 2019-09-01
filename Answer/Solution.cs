using System;

namespace Answer
{
    public class Solution
    {
        /*
        Given an integer array nums, find the contiguous subarray
        (containing at least one number) which has the largest sum
        and return its sum.

        Example:

        Input: [-2,1,-3,4,-1,2,1,-5,4],
        Output: 6
        Explanation: [4,-1,2,1] has the largest sum = 6.
        Follow up:

        If you have figured out the O(n) solution, try coding another
        solution using the divide and conquer approach, which is more
        subtle.
        */
        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                int currentSum = nums[i];

                if (currentSum > max)
                {
                    max = currentSum;
                }

                for (int j = i + 1; j < nums.Length; j++)
                {
                    currentSum += nums[j];

                    if (currentSum > max)
                    {
                        max = currentSum;
                    }
                }
            }

            return max;
        }
    }
}
