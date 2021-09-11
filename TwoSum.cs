//https://leetcode.com/explore/learn/card/array-and-string/205/array-two-pointer-technique/1153/
public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int start = 0;
        int finish = numbers.Length - 1;
        int[] result = new int[] { -1, -1 };

        while (start < finish)
        {
            if (numbers[start] + numbers[finish] < target)
            {
                start++;
            }
            else if (numbers[start] + numbers[finish] > target)
            {
                finish--;
            }
            else
            {
                result[0] = start + 1;
                result[1] = finish + 1;
                return result;
            }
        }

        return result;
    }
}
