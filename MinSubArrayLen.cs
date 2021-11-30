public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int i = 0;
        int sum = nums[i];
        int j = i + 1;
        int min = 0;
        while (j < nums.Length)
        {
            if (nums[i] == target || nums[j] == target)
            {
                return 1;
            }
            sum = sum + nums[j];

            if (sum == target)
            {
                if (min > j - i + 1 && min > 0)
                {
                    min = j - i + 1;
                }
                min = j - i + 1;
            }

            if (sum > target)
            {
                i++;
                j = i;
                sum = nums[i];
                //return j;
            }
            j++;
        }

        return min;
    }
}
