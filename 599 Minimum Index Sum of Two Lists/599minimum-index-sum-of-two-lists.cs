public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        List<string> result = new List<string>();

        if (list1.Length == 1)
        {
            result.Add(list1[0]);
            return result.ToArray();
        }
        
        if (list2.Length == 1)
        {
            result.Add(list2[0]);
            return result.ToArray();
        }
        
        
        Dictionary<string,int> dictList1 = new Dictionary<string,int>();
        
        for (int i = 0; i < list1.Length; i++)
        {
            dictList1.Add(list1[i], i);
        }

        int indexSum = (list1.Length-1) + (list2.Length-1);
        
        for (int i = 0; i < list2.Length; i++)
        {
            //Console.WriteLine("i : " + i);
            if (dictList1.ContainsKey(list2[i]))
            {
                //Console.WriteLine("indexSum: " + indexSum);
                int indexVal = dictList1[list2[i]];
                //Console.WriteLine("indexVal : " + indexVal);
                //Console.WriteLine("i + indexVal: " + (i + indexVal));
                if (i + indexVal < indexSum)
                {
                    indexSum = i + indexVal;
                    //Console.WriteLine("indexSum: " + indexSum);
                    result.Clear();
                    result.Add(list2[i]);    
                } else if (i + indexVal == indexSum)
                {
                    indexSum = i + indexVal;
                    result.Add(list2[i]);    
                }
            }
        }
        
        return result.ToArray();
    }
}