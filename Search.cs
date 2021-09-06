public class Solution
{
    public int Search(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length - 1;
        int med;
        while (l < r)
        {
            med = (l + r) / 2;
            if (nums[med] > nums[r])
            {
                l = med + 1;
            }
            else
            {
                r = med;
            }
        }
        int bound = l;
        if (nums[bound] == target)
        {
            return bound;
        }
        r = nums.Length - 1;
        while (bound < r)
        {
            med = (bound + r) / 2;
            if (nums[med] >= target)
            {
                r = med;
            }
            else
            {
                bound = med + 1;
            }
        }
        if (nums[bound] == target)
        {
            return bound;
        }
        bound = l - 1;
        l = 0;
        while (l < bound)
        {
            med = (l + bound) / 2;
            if (nums[med] >= target)
            {
                bound = med;
            }
            else
            {
                l = med + 1;
            }
        }
        if (nums[l] == target)
        {
            return l;
        }
        return -1;
    }
}
