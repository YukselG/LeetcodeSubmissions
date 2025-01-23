public class MyCircularQueue {
    int head = 0;
    int tail = 0;
    int count = 0;
    List<int> Queue;
    int capacity;

    public MyCircularQueue(int k) {
        Queue = new List<int>(k);
        capacity = k;
        for (int i = 0; i < k; i++)
        {
            Queue.Add(0);
        }
    }
    
    public bool EnQueue(int val) {
        if (IsFull())
        {
            return false;
        } else if (IsEmpty())
        {
            Queue[tail] = val;
            tail++;
            count++;
            return true;
        } else if (tail == capacity)
        {
            tail = 0;
            Queue[tail] = val;
            //Queue.Insert(tail, val);
            tail++;
            count++;
            return true;
        } else
        {
            Queue[tail] = val;
            //Queue.Insert(tail, val);
            tail++;
            count++;

            return true;
        }

    }
    
    public bool DeQueue() {
        if (IsEmpty())
        {
            return false;
        } else if (head == capacity-1) {
            Queue[head] = 0;
            head = 0;
            count--;
            return true;
        } else {
            Queue[head] = 0;
            head++;
            count--;
            return true;
        }
    }
    
    public int Front() {
        if (IsEmpty())
        {
            return -1;
        } else {
            return Queue[head];
        }
    }
    
    public int Rear() {
        if (IsEmpty())
        {
            return -1;
        } else {
            return Queue[tail-1];
        }
    }
    
    public bool IsEmpty() {
        if (count == 0)
        {
            head = 0;
            tail = 0;
            return true;
        } else return false;
    }
    
    public bool IsFull() {
        if (count == capacity)
        {
            return true;
        } else return false;
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