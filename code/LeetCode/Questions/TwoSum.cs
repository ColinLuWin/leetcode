using System;

namespace LeetCode.Questions
{
    public class TwoSum
    {
        public int[] Test(int[] nums, int target)
        {
            for (int idx = 0; idx < nums.Length; ++idx)
            {
                for (int idx2 = idx; idx2 < nums.Length; ++idx2)
                {
                    if (idx == idx2)
                        continue;

                    if (target == nums[idx] + nums[idx2])
                        return new int[] { idx, idx2 };
                }
            }

            return new int[] { };
        }
    }
}
