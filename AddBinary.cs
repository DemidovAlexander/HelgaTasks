//https://leetcode.com/explore/learn/card/array-and-string/203/introduction-to-string/1160/
public class Solution
{
    public string AddBinary(string a, string b)
    {
        char[] A = a.ToCharArray();
        char[] B = b.ToCharArray();
        int maxLength;
        if (A.Length > B.Length)
        {
            maxLength = A.Length;
        }
        else
        {
            maxLength = B.Length;
        }

        string s = "";
        bool carry = false;

        int i = A.Length - 1;
        int j = B.Length - 1;
        for (int c = 0; c < maxLength; c++)
        {
            if (Char.GetNumericValue(A[i]) + Char.GetNumericValue(B[j]) > 1)
            {
                if (carry)
                {
                    s = '1' + s;
                }
                else
                {
                    s = '0' + s;
                }
                carry = true;
            }
            else
            {
                if (carry)
                {
                    if (
                        Char.GetNumericValue(A[i]) +
                        Char.GetNumericValue(B[j]) ==
                        1
                    )
                    {
                        s = '0' + s;
                    }
                    else
                    {
                        s = '1' + s;
                        carry = false;
                    }
                }
                else
                {
                    int t =
                        (int) Char.GetNumericValue(A[i]) +
                        (int) Char.GetNumericValue(B[j]);
                    s = t.ToString() + s;
                }
            }

            if (i > 0)
            {
                i--;
            }
            else
            {
                A[i] = '0';
            }
            if (j > 0)
            {
                j--;
            }
            else
            {
                B[j] = '0';
            }
        }
        if (carry)
        {
            s = '1' + s;
        }
        return s;
    }
}
