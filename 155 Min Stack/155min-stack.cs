public class MinStack {
    // using a min stack that only holds values that is a new minimum
    Stack mainStack;
    Stack minStack;

    public MinStack() {
        mainStack = new Stack();
        minStack = new Stack();
    }
    
    public void Push(int val) {
        mainStack.Push(val);
        // if min stack empty, push the val since that will be the new min
        if (minStack.Count == 0)
        {
            minStack.Push(val);
        } else if (val <= (int)minStack.Peek()) // we add duplicates of min values as well
        {
            // if the new val is lesser than the min, push that val on top making it the min
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        int val = (int)mainStack.Pop();
        
        // we pop from the min stack as well, if the min value (latests pushed value) in minStack is the same as the val popped from the main stack
        if (val == (int)minStack.Peek())
        {
            minStack.Pop();
        }

    }
    
    public int Top() {
        return (int)mainStack.Peek();
    }
    int getMinCounter = 0;
    
    public int GetMin() {
        // we peek the min stack and not the main stack, since min stack holds the min value
        return (int)minStack.Peek();
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