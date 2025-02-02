public class Solution {
    Dictionary<int, int> cache = new Dictionary<int,int>();
    
    public int Fib(int n) {
        int result = 0;
    
        if (cache.ContainsKey(n))
        {
            result = cache[n];
            return result;
        }
        
        if (n == 0 || n == 1)
        {
            result = n;
            return result;
        } else {
            result = Fib(n-1) + Fib(n-2);
            cache.Add(n, result);
        }
        
        
        return result;
    }
}

