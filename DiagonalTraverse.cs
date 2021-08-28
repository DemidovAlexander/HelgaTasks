//https://leetcode.com/explore/learn/card/array-and-string/202/introduction-to-2d-array/1167/
public class Solution
{
    public int[] FindDiagonalOrder(int[][] mat)
    {
        int rows = mat.Length; //rows
        int cols = mat[0].Length; //cols
        int[] arr = new int[cols * rows];
        int index = 0;
        int row = 0;
        int column = 0;
        for (int d = 0; d < rows + cols - 1; d++)
        {
            ArrayList list = new ArrayList();
            if (d < cols)
            {
                row = 0;
                column = d;
            }
            else
            {
                row = d - cols + 1;
                column = cols - 1;
            }

            while (row < rows && column > -1)
            {
                list.Add(mat[row][column]);
                row++;
                column--;
            }
            if (d % 2 == 0)
            {
                list.Reverse();
            }
            for (int i = 0; i < list.Count; i++)
            {
                arr[index] = (int) list[i];
                index++;
            }
        }
        return arr;
    }
}
