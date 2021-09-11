//https://leetcode.com/explore/lesInArrayn/csInArrayd/sInArrayray-and-string/204/conclusion/1165/
public class Solution
{
    public string ReverseWords(string s)
    {
        string res = "";
        string str = "";
        char [] sInArray = s.ToCharArray();;
        for (int i = 0; i < sInArray.Length; i++)
        {
            if (sInArray[i] == ' ')
            {
                str = str + res + sInArray[i];
                res = "";
            }
            else
            {
                res = sInArray[i] + res;
            }
        }
        return str + res;
    }
}
