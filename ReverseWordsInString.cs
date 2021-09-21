//https://leetcode.com/explore/learn/card/array-and-string/204/conclusion/1164/
//можно ли использовать встроенные функции?
public class Solution
{
    public string ReverseWords(string s)
    {
        string res = "";
        string substr = "";
        string[] arr = s.Split(new char[] { ' ' });
        foreach (var item in arr)
        {
            substr = item.Trim();
            if (substr != "")
            {
                res = substr + " " + res;
            }
        }
        res = res.Trim();
        return res;
    }
}
