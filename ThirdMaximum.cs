//https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3231/
public class Solution
{
    public int ThirdMax(int[] nums)
    {
        if (nums.Length < 3)
        {
            return nums[nums.Length - 1];
        }
        int count = 1;
        int max = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (count == 3)
            {
                return nums[i - 1];
            }
            if (nums[i - 1] != nums[i])
            {
                count++;
            }
            if (nums[i - 1] < nums[i])
            {
                max = nums[i];
            }
        }
        if (count == 3)
        {
            return nums[nums.Length - 1];
        }
        else
        {
            return max;
        }
    }
}
