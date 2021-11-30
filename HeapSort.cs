//https://leetcode.com/problems/sort-an-array/submissions/
public class Solution
{
    public int[] SortArray(int[] nums)
    {
        int size = nums.Length;
        for (int i = (size - 2) / 2; i >= 0; i--)
        {
            heapify (nums, i, size);
        }
        int[] res = new int[nums.Length];
        for (int i = 0; i < res.Length; i++)
        {
            res[i] = ExtractMin(nums, ref size);
        }
        return res;
    }

    public static int ExtractMin(int[] nums, ref int size)
    {
        if (size == 0)
        {
            return nums.Min();
        }
        if (size == 1)
        {
            return nums[0];
        }
        int t = nums[0];
        nums[0] = nums[size - 1];
        size--;
        heapify(nums, 0, size);

        return t;
    }

    public static void heapify(int[] arr, int i, int size)
    {
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        int root = i;
        if (left < size && arr[root] > arr[left])
        {
            root = left;
        }
        if (right < size && arr[root] > arr[right])
        {
            root = right;
        }
        if (root != i)
        {
            int t = arr[root];
            arr[root] = arr[i];
            arr[i] = t;
            heapify (arr, root, size);
        }
    }
}
