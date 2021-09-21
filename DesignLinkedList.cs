//https://leetcode.com/explore/learn/card/linked-list/209/singly-linked-list/1290/
public class Node
{
    public Node(int val)
    {
        Val = val;
    }

    public int Val { get; set; }
    public Node Next { get; set; }
}

public class MyLinkedList
{
    Node _tail;
    Node _head;
    int Count = 0;

    /** Initialize your data structure here. */
    public MyLinkedList()
    {
    }

    /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
    public int Get(int index)
    {
        int res = -1;
        if (index < 0 || index > Count - 1)
        {
            return -1;
        }
        int count = 0;

        //Node prevNode=null;
        Node curNode = _head;
        while (curNode != null)
        {
            if (count == index)
            {
                res = curNode.Val;
                break;
            }
            count++;
            curNode = curNode.Next;
        }
        return res;
    }

    /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
    public void AddAtHead(int val)
    {
        Node newHead = new Node(val);
        if (_head == null)
        {
            _head = newHead;
            _tail = newHead;
        }
        else
        {
            newHead.Next = _head;
            _head = newHead;
        }
        Count++;
    }

    /** Append a node of value val to the last element of the linked list. */
    public void AddAtTail(int val)
    {
        Node newTail = new Node(val);
        if (_tail == null)
        {
            _head = newTail;
            _tail = newTail;
        }
        else
        {
            _tail.Next = newTail;
            _tail = newTail;
            //_tail.Next=null;
        }
        Count++;
    }

    /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
    public void AddAtIndex(int index, int val)
    {
        if (index > Count)
        {
            return;
        }
        if (index == Count)
        {
            AddAtTail (val);
            return;
        }
        if (index == 0)
        {
            AddAtHead (val);
            return;
        }
        Node curNode = _head;
        Node prevNode = null;
        int count = 0;
        while (curNode != null)
        {
            if (count == index)
            {
                Node node = new Node(val);
                node.Next = curNode;
                prevNode.Next = node;
                break;
            }
            prevNode = curNode;
            curNode = curNode.Next;
            count++;
        }
        Count++;
    }

    /** Delete the index-th node in the linked list, if the index is valid. */
    public void DeleteAtIndex(int index)
    {
        if (index < 0 || index > Count - 1)
        {
            return;
        }
        Node curNode = _head;
        Node prevNode = null;
        int count = 0;
        while (curNode != null)
        {
            if (count == index)
            {
                if (prevNode == null)
                {
                    _head = curNode.Next;
                    /*if (_head == null)
                        {
                          _tail = null;
                      }*/
                }
                else
                {
                    prevNode.Next = curNode.Next;
                    if (curNode.Next == null)
                    {
                        _tail = prevNode;
                    }
                }

                break;
            }
            prevNode = curNode;
            curNode = curNode.Next;
            count++;
        }

        Count--;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */
