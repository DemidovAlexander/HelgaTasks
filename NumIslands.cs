//https://leetcode.com/explore/learn/card/queue-stack/231/practical-application-queue/1374/
public class Solution
{
    public int NumIslands(char[][] grid)
    {
        int root_row = 0;
        int root_col = 0;
        int rowCount = grid.Length;
        int colCount = grid[0].Length;

        int count = 0;
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                if (grid[i][j] == '1')
                {
                    BFS (grid, i, j);
                    count++;
                }
            }
        }

        return count;
    }

    public static void BFS(char[][] arr, int row, int col)
    {
        var queue = new Queue<(int row, int col)>();
        queue.Enqueue((row, col));
        int arrRows = arr.Length;
        int arrCols = arr[0].Length;
        while (queue.Count > 0)
        {
            int size = queue.Count;
            var root = queue.Dequeue();
            int down = root.Item1 + 1;
            int right = root.Item2 + 1;
            int up = root.Item1 - 1;
            int left = root.Item2 - 1;

            if (down < arrRows && arr[down][root.Item2] == '1')
            {
                queue.Enqueue((down, root.Item2));
                arr[down][root.Item2] = '0';
            }
            if (right < arrCols && arr[root.Item1][right] == '1')
            {
                queue.Enqueue((root.Item1, right));
                arr[root.Item1][right] = '0';
            }
            if (up >= 0 && arr[up][root.Item2] == '1')
            {
                queue.Enqueue((up, root.Item2));
                arr[up][root.Item2] = '0';
            }
            if (left >= 0 && arr[root.Item1][left] == '1')
            {
                queue.Enqueue((root.Item1, left));
                arr[root.Item1][left] = '0';
            }
        }
    }
}
