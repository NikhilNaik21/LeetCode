public class Solution {
    public int Reverse(int x) {
        int reverseNumber = 0;

        while(x != 0){
            int Remainder = x % 10;

      if (reverseNumber > int.MaxValue / 10 || reverseNumber < int.MinValue / 10)
                return 0;


            reverseNumber =  reverseNumber * 10 + Remainder;
            x = x/10;
        }
        return reverseNumber;
    }
}
