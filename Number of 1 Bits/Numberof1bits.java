public class Solution {
    // you need to treat n as an unsigned value
    public int hammingWeight(int n) {
        
                int R=0;
        while(n!=0)
        {
            R= R+(n&1);   
             n=n>>>1;      
             
        }
        return R;
        
    }
}
