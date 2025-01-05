// --------------------------------- THE BELOW IS FOR THE DOUBLY LINKED LIST ---------------------------------
public class Node {
    public int val;
    public Node prev;
    public Node next;
    
    public Node(int input)
    {
        val = input;
    }
}

public class MyLinkedList {
    public Node head;
    public Node tail;
    public int length = 0;
    
    public MyLinkedList()
    {
        head = null;
        tail = null;
    }
    
    public int Get(int index)
    {
        if (index < 0 || index >= length)
        {
            return -1;
        }
        
        if (index == 0)
        {
            return head.val;
        }
        
        if (index == length - 1)
        {
            return tail.val;
        }
        
        Node indexNode = head;
        
        for (int i = 0; i < index; i++)
        {
            indexNode = indexNode.next;
        }
        
        return indexNode.val;

    }
    
    public void AddAtHead(int val)
    {
        Node newNode = new Node(val);
        
        if (length == 0)
        {
            head = newNode;
            tail = newNode;
            
            head.prev = null;
            head.next = null;
            tail.prev = null;
            tail.next = null;
        }
        
        if (length == 1)
        {
            head = newNode;
            tail.prev = newNode;
            newNode.next = tail;
            newNode.prev = null;
            tail.next = null;
        }
        
        if (length > 1)
        {
            head.prev = newNode;
            newNode.next = head;
            head = newNode;
        }
        
        length++;
    }
    
    public void AddAtTail(int val)
    {
        Node newNode = new Node(val);
        
        if (length == 0)
        {
            AddAtHead(val);
            return;
        }
        
        tail.next = newNode;
        newNode.prev = tail;
        newNode.next = null;
        tail = newNode;
        
        length++;
    }
    
    public void AddAtIndex(int index, int val)
    {
        if (index < 0 || index > length)
        {
            //Console.WriteLine("AddAtIndex < 0 or > length: " + index);

            return;
        }
        
        if (index == 0)
        {
            //Console.WriteLine("AddAtIndex == 0: " + index);
            AddAtHead(val);
            return;
        }
        
        if (index == length)
        {
            //Console.WriteLine("AddAtIndex == length: " + index);
            AddAtTail(val);
            return;
        }
        
        // int counter = 0;
        
        Node indexNode = head;
        
        for (int i = 0; i < index; i++)
        {
            //Console.WriteLine("AddAtIndex for loop: " + index);

            indexNode = indexNode.next;
        }
        //Console.WriteLine("AddAtIndex indexNode val: " + indexNode.val);
        
        Node newNode = new Node(val);
        
        newNode.next = indexNode;
        newNode.prev = indexNode.prev;
        indexNode.prev.next = newNode;
        indexNode.prev = newNode;

        length++;
    }
    
    public void DeleteAtIndex (int index)
    {
        
        // checking for incorrect inputted indexes
        if (index >= length || index < 0)
        {
            return;
        }
        
        if (index == 0)
        {
            if (length == 1)
            {
                head = null;
                tail = null;
            } else {
                head = head.next;
                head.prev = null;
            }
            length--;
            return;
        }
        
        if (index == length - 1)
        {
            tail = tail.prev;
            tail.next = null;
            length--;
            return;
        }
        
        Node indexNode = head;
        
        for (int i = 0; i < index; i++)
        {
            indexNode = indexNode.next;            
        }
        
        indexNode.next.prev = indexNode.prev;
        indexNode.prev.next = indexNode.next;
        indexNode = null;
        
        length--;
    }
}



// --------------------------------- THE BELOW IS FOR THE SINGLY LINKED LIST -----------------------------------
/*
public class Node {
    public int val;
    public Node next;
    public Node ()
    {
    }
    public Node (int input)
    {
        val = input;
        next = null;
    }
    
}
    
public class MyLinkedList {
    Node head;
    Node tail;
    int length = 0;

    public MyLinkedList() {
        head = null;
        tail = null;
    }
    
    public int getLength()
    {
        return length;
    }
    
    public int Get(int index) {
        if (index < 0 || index >= length)
        {
            return -1;
        }
        
        Node tempNode = head;

        for (int i = 0; i < index; i++)
        {    
            tempNode = tempNode.next;
        }
        
        return tempNode.val;

    }
    
    public void AddAtHead(int val) {
        Node newNode = new Node(val);
        
        // if the head is null, it means the list is empty, and we have to assign the head and the tail to the new node created.
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        } else {
            newNode.next = head;
            head = newNode;
        }
        length++;
        Console.WriteLine("head val: " + head.val);
    }
    
    public void AddAtTail(int val) {
        Node newNode = new Node(val);
        
        // if the tail is null, it means the list is empty, and we have to assign the head and the tail to the new node created.
        if (tail == null)
        {
            tail = newNode;
            head = newNode;
        } else {
            tail.next = newNode;
            tail = newNode;
        }
        // When adding at the tail, newNode.next will be null both in cases of an empty list and a list with elements;
        newNode.next = null;
        length++;      
    }
    
    public void AddAtIndex(int index, int val) {
        Node newNode = new Node(val);
        Node tempNode = head;

        int lengthOfList = getLength();
        
        if (index < 0 || index > length)
        {
            return;
        }
        
        if (index == length)
        {
            AddAtTail(val);
            // we already increment in the method for AddAtTail, so no need to increment here
            return;
        }
        
        if (index == 0)
        {
            AddAtHead(val);
            // we already increment in the method for AddAtHead, so no need to increment here
            return;
        }


        for (int i = 0; i < index-1; i++)
        {            

            tempNode = tempNode.next;
        }
        newNode.next = tempNode.next;
        tempNode.next = newNode;
        length++;
        return;
    }
    
    public void DeleteAtIndex(int index) {
        Node tempNode = head;
        Node tempNodeDelete = head;
        
        // checking for incorrect inputted indexes
        if (index >= length || index < 0)
        {
            Console.WriteLine("delete method: index out of bounds");
            return;
        }
        
        // deletion of head node
        if (index == 0)
        {
            if (length == 1)
            {
                head = null;
                tail = null;
            } else {
                head = head.next;
            }
            length--;
            return;
        }
                
        // deleting of last node
        if (index == length-1)
        {
            for (int i = 1; i < length-1; i++)
            {
                tempNodeDelete = tempNodeDelete.next;
            }
            tail = tempNodeDelete;
            tempNodeDelete.next = null;
            length--;
            return;
        }
        
        // deletion of node between head and tail
        for (int i = 1; i <= index; i++)
        {
            tempNodeDelete = tempNodeDelete.next;
            if (i == index)
            {
                 tempNode.next = tempNodeDelete.next;
            }
            
            if (i < index)
            {
                tempNode = tempNode.next;
            }

        }
        length--;
        return;
    }
}
*/

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */