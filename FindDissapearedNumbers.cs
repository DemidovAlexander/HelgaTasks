//https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3270/
public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        IList<int> testValues = new List<int>();
        int[] arr = new int[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            arr[i] = 0;
        }
        for (int j = 0; j < nums.Length; j++)
        {
            arr[nums[j]] = arr[nums[j]] + 1;
        }
        for (int t = 0; t < arr.Length; t++)
        {
            if (arr[t] == 0 && t != 0)
            {
                testValues.Add (t);
            }
        }
        return testValues;
    }
}
