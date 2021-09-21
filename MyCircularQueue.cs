//https://leetcode.com/explore/learn/card/queue-stack/228/first-in-first-out-data-structure/1337/
public class MyCircularQueue
{
    int head = -1;
    int tail = -1;
    int[] queue;
    int count;

    public MyCircularQueue(int k)
    {
        queue = new int[k];
        head = 0;
        count = 0;
    }

    public bool EnQueue(int value)
    {
        if (IsFull())
        {
            return false;
        }
        if (head < 0)
        {
            head++;
        }

        /*if (tail<queue.Length-1){
              tail=tail+1;                
        }
        else {tail=0;}*/
        tail = (tail + 1) % queue.Length;
        queue[tail] = value;
        count++;
        return true;
    }

    public bool DeQueue()
    {
        if (IsEmpty())
        {
            return false;
        }
        queue[head] = -1;

        /*if (head<queue.Length-1){
          head++;
        }
        else {head=0;}*/
        head = (head + 1) % queue.Length;
        count--;
        if (count <= 0)
        {
            head = -1;
            tail = -1;
        }
        return true;
    }

    public int Front()
    {
        if (head == -1)
        {
            return -1;
        }
        return queue[head];
    }

    public int Rear()
    {
        if (tail == -1)
        {
            return -1;
        }
        return queue[tail];
    }

    public bool IsEmpty()
    {
        if (count <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsFull()
    {
        if (count == queue.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */
