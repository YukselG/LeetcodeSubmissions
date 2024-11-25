public class Solution {
    public string AddBinary(string a, string b) {

        int biggestLength = 0;
        int lowestLength = 0;
        if (a.Length >= b.Length)
        {
            biggestLength = a.Length;
            lowestLength = b.Length;
            //Console.WriteLine(lowestLength);

        } else {
            biggestLength = b.Length;
            lowestLength = a.Length;
        }
        string start = "";
        for (int i = 0; i < biggestLength; i++)
        {
            start = start + "0";
        }
        //Console.WriteLine("start: " + start);
        
        StringBuilder sum = new StringBuilder(start, biggestLength);
        //Console.WriteLine(sum.Capacity);
        string carry = "0";
              
        //Console.WriteLine("lowestLength: " + lowestLength);

        int j = 0;
        for (int i = lowestLength-1; i >= 0; i--)
        {
            //Console.WriteLine("i :" + i);
            //Console.WriteLine("a " + (a.Length-1-i));
            //Console.WriteLine("b " + (b.Length-1-i));
            //Console.WriteLine("carry before addbits: " + carry);
            string AddedBits = AddTwoBitsWithCarry(a[a.Length-1-j].ToString(), b[b.Length-1-j].ToString(), ref carry);
            //Console.WriteLine("carry after addbits: " + carry);
            sum[sum.Length-1-j]= AddedBits[0];
            j++;
        }
        //Console.WriteLine("carry after addbits: " + carry);
        
        if (a.Length == b.Length && carry == "1")
        {
            sum.Insert(0, "1");
            
            return sum.ToString();
        }
        
        string longer = a.Length > b.Length ? a : b;
        
        for (int i = lowestLength; i < biggestLength; i++)
        {
            string AddedBits = AddOneBitWithCarry(longer[biggestLength-i-1].ToString(),  ref carry);
            sum[sum.Length-1-j]= AddedBits[0];
            j++;
        }
        

        if (carry == "1")
        {
            sum.Insert(0, "1");
            return sum.ToString();
        }

        string AddTwoBitsWithCarry (string bit1, string bit2, ref string carry)
        {
            //Console.WriteLine("AddTwoBits method carry: " + carry);

            if (carry == "1")
            {
                //Console.WriteLine("AddTwoBits method if carry = 1: " + carry);

                if (bit1.Equals(bit2))
                {
                    carry = bit1 == "1" ? "1" : "0";
                    //Console.WriteLine("AddTwoBits method if carry = 1: " + carry);

                    return "1";
                } else {
                    carry = "1";
                    //Console.WriteLine("AddTwoBits method if carry = 1: " + carry);

                    return "0";
                }
            }
            
            else
            {
                //Console.WriteLine("AddTwoBits method if carry = 0: " + carry);

                if (bit1.Equals(bit2))
                {
                    carry = bit1 == "0" ? "0" : "1";
                    //Console.WriteLine("AddTwoBits method if carry = 0: " + carry);
                    return "0";
                } else {
                    carry = "0";
                    return "1";
                }
            }
        }
        
        string AddOneBitWithCarry (string bit1, ref string carry)
        {
            if (!bit1.Equals(carry))
            {
                carry = "0";
                return "1";
            } else {
                if (carry == "1")
                {
                    carry = "1";
                    return "0";
                } else {
                    carry = "0";
                    return "0";
                }
            }  
        }
        
        return sum.ToString();
    }
}