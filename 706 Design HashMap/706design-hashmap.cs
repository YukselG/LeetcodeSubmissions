public class Pair {
    public int Key = 0;
    public int Val = 0;
    
    public Pair (int key, int val) {
        Key = key;
        Val = val;
    }
}

public class Bucket {
    public List<Pair> Pairs = new List<Pair>(10000);
    
    public void addToBucket(int key, int val)
    {
        // If key exists, update the value, else create new Pair
        Pair pair = GetPair(key);
        if (pair != null)
        {
            pair.Val = val;
        } 
        else 
        {
            Pairs.Add(new Pair(key, val));
        }
    }
    
    public void removeKey(int key)
    {
        //Pair pair = Pairs.Find(p => p.Key == key);
        Pair pair = GetPair(key);
        if (pair != null)
        {
            Pairs.Remove(pair);
        } else return;
    }
    
    /*
    public bool bucketContainsKey(int key)
    {
        bool keyExists = Pairs.Contains(p => p.Key == key);
        return keyExists;
    }
    */
    
    public int getValByKey(int key)
    {
        //Console.WriteLine("Bucket - GetValByKey: key:" + key);
        Pair pair = GetPair(key);
        
        if (pair != null)
        {
            return pair.Val;
        } else {
            return -1;
        }
    }
    

    public Pair GetPair(int key)
    {
        //Console.WriteLine("Bucket - GetPair: key:" + key);

        //bool keyExists = bucketContainsKey(key);
        Pair pair = Pairs.Find(p => p.Key == key);
        //Console.WriteLine("Bucket - GetPair: pair: " + pair);
        if (pair != null)
        {
            //Console.WriteLine("Bucket - GetPair: pair is not null");
            //Console.WriteLine("Bucket - GetPair: pair: Key " + pair.Key + ", Val: " + pair.Val);
            return pair;
        } else return null;        
    }
}

public class MyHashMap {
    private const int BucketSize = 100;
    List<Bucket> buckets;

    public MyHashMap() {
        buckets = new List<Bucket>(100);
        for (int i = 0; i < 100; i++)
        {
            buckets.Add(null); // Initialize each index with null
        }
    }
    
    public void Put(int key, int val) {
        ////Console.WriteLine("Buckets: count: " + buckets.Count);
        //Console.WriteLine("Buckets: capacity: " + buckets.Capacity);

        int bucket = getBucket(key);
        //Console.WriteLine("bucket: " + bucket);
        
        if (buckets[bucket] == null)
        {
            //Console.WriteLine("Buckets[bucket] before: " + buckets[bucket]);
            Bucket newBucket = new Bucket();
            buckets[bucket] = newBucket;
            //Console.WriteLine("Buckets[bucket] after: " + buckets[bucket]);

            newBucket.addToBucket(key, val);
        } else {
            buckets[bucket].addToBucket(key, val);
            //bool containsKey = bucket.bucketContainsKey(key);
        }
    }
    
    public int Get(int key) {
        int bucket = getBucket(key);
        //Console.WriteLine("HasMap - Get method: key: " + key);
        //Console.WriteLine("Get method - buckets[bucket]:  " + buckets[bucket]);
        
        if (buckets[bucket] != null)
        {
            int val = buckets[bucket].getValByKey(key);
            //Console.WriteLine("val " + val);
            return val;
        } else return -1;
    }
    
    public void Remove(int key) {
        int bucket = getBucket(key);
        //Console.WriteLine("HashMap: Remove method - key:  " + key);
        //Console.WriteLine("HashMap: Remove method - bucket:  " + bucket);
        //Console.WriteLine("HashMap: Remove method - buckets[bucket]:  " + buckets[bucket]);

        if (buckets[bucket] != null)
        {
            buckets[bucket].removeKey(key);
        }
    }
        
    public int getBucket (int key)
    {
        return key % BucketSize; 
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */