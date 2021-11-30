//https://leetcode.com/explore/learn/card/queue-stack/230/usage-stack/1360/
public class MinStack
{
    ArrayList stack;

    /** initialize your data structure here. */
    public MinStack()
    {
        stack = new ArrayList();
    }

    public void Push(int val)
    {
        stack.Add (val);
    }

    public void Pop()
    {
        //if (stack.Count>0) {stack.RemoveAt(stack.Count-1);}

        stack.RemoveAt(stack.Count - 1);
    }

    public int Top()
    {
        //if (stack.Count>0) {
        return (int) stack[stack.Count - 1];
    }

    public int GetMin()
    {
        int min = 0;
        for (int i = 0; i < stack.Count; i++)
        {
            if ((int) stack[min] > (int) stack[i])
            {
                min = i;
            }
        }
        return (int) stack[min];
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
