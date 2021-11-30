//https://leetcode.com/explore/learn/card/array-and-string/205/array-two-pointer-technique/1154/
public class Solution
{
    public int ArrayPairSum(int[] nums)
    {
        int i;
        int j;
        int min;
        int sum = 0;
        for (i = 0; i < nums.Length - 1; i++)
        {
            min = i;
            for (j = i + 1; j < nums.Length; j++)
            {
                if (nums[min] > nums[j])
                {
                    min = j;
                }
            }
            int t = nums[i];
            nums[i] = nums[min];
            nums[min] = t;
            if (i % 2 == 0)
            {
                sum = sum + nums[i];
            }
        }
        return sum;
    }
}
