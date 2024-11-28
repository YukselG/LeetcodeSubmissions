public class Bucket {
    public int length = 0;
    public int[] arrayOfKeys = new int[10000];
    
    public void addToBucket(int key)
    {
        // check for duplicates
        if (bucketContainsKey(key) == true)
        {
            return;
        }
        arrayOfKeys[length] = key;
        length++;
    }
    
    public void removeFromBucket (int key)
    {
        // loop to find the specific key
        for (int i = 0; i < length; i++)
        {
            if (arrayOfKeys[i] == key)
            {
                // 'remove' the key (j) by overwriting it and shifting next elements to the left
                for (int j = i; j < length-1; j++)
                {
                    arrayOfKeys[j] = arrayOfKeys[j+1];
                }
                // setting last slot to 0 (default value).
                arrayOfKeys[length-1] = 0;
                // decrementing length to keep correct order and no empty slots
                length--;
                // return right after removing
                return; 
            }
        }
    }
    
    public bool bucketContainsKey (int key)
    {
        for (int i = 0; i < length; i++)
        {
            if (arrayOfKeys[i] == key)
            {
                return true;
            }
        }
        return false;
    }
}

public class MyHashSet {   
    Bucket[] buckets = new Bucket[100];   

    public MyHashSet() {
        
    }
    
    public void Add(int key) {
        int bucket = getBucket(key);
        
        if (buckets[bucket] == null)
        {
            //nsole.WriteLine("Add method - key: " + key);
            Bucket newBucket = new Bucket();
            buckets[bucket] = newBucket;
            newBucket.addToBucket(key);
        } else {
            bool keyExists = Contains(key);
            if (keyExists == true)
            {
                //nsole.WriteLine("Add method - key exists: " + key);
                return;
            } else {
                //Bucket newBucket = new Bucket();
                buckets[bucket].addToBucket(key); 
            }
        }
    }
    
    public void Remove(int key) {
        int bucket = getBucket(key);
        //nsole.WriteLine("Contains method: " + "Key: " + key + " Bucket variable: " + bucket);
        if (buckets[bucket] == null)
        {
            //nsole.WriteLine("Contains method: if buckets[bucket] == null");
            return;
        } else {
            //console.WriteLine("Contains method: inside else statement");
            //Bucket newBucket = new Bucket();

            buckets[bucket].removeFromBucket(key);
            /*
            for (int i = 0; i < 10000; i++)
            {
                if (buckets[bucket].arrayOfKeys[i] == key)
                {
                    buckets[bucket].removeFromBucket(key);
                    //buckets[bucket].arrayOfKeys[i] = -1;
                    //buckets[bucket].length--;
                }
            }
            */
            return;
        }
    }
    
    public bool Contains(int key) {     
        int bucket = getBucket(key);
        //Console.WriteLine("Contains method: " + "Key: " + key + " Bucket variable: " + bucket);
        if (buckets[bucket] == null)
        {
            //Console.WriteLine("Contains method: if buckets[bucket] == null");
            return false;
        } else {
            //Console.WriteLine("Contains method: inside else statement");
            //Bucket newBucket = new Bucket();
            return buckets[bucket].bucketContainsKey(key);
            
            /*for (int i = 0; i < 10000; i++)
            {
                if (buckets[bucket].arrayOfKeys[i] == key)
                {
                    return true;
                }
            }
            return false;
            */
        }
        
    }
    
    public int getBucket (int key)
    {
        int resultBucket = 0;
        return resultBucket = key % 100; 
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */