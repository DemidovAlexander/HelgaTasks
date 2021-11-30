//https://leetcode.com/explore/learn/card/queue-stack/230/usage-stack/1361/
public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        char[] arr = s.ToCharArray();
        if (arr.Length % 2 != 0)
        {
            return false;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == '(' || arr[i] == '[' || arr[i] == '{')
            {
                stack.Push(arr[i]);
                if (i == arr.Length - 1)
                {
                    return false;
                }
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                if (
                    (arr[i] == ')' && stack.Peek() == '(') ||
                    (arr[i] == ']' && stack.Peek() == '[') ||
                    (arr[i] == '}' && stack.Peek() == '{')
                )
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
                if (arr.Length - i - 1 < stack.Count)
                {
                    return false;
                }
            }
        }
        return true;
    }
}
