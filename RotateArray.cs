//https://leetcode.com/explore/learn/card/array-and-string/204/conclusion/1182/
public class Solution
{
    public void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            int t = nums[start];
            nums[start] = nums[end];
            nums[end] = t;
            start++;
            end--;
        }
    }

    public void Rotate(int[] nums, int k)
    {
        int[] arr = new int[nums.Length];

        //int arrInd=nums.Length-k;
        k = k % nums.Length;
        if (k == 0)
        {
            return;
        }
        Reverse(nums, nums.Length - k, nums.Length - 1);
        Reverse(nums, 0, nums.Length - k - 1);
        Reverse(nums, 0, nums.Length - 1);
    }
}
