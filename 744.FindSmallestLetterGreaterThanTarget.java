class Solution {
    public char nextGreatestLetter(char[] letters, char target) {
        int length = letters.length;
        if(letters[length-1]<=target)
        {
            return letters[0];
        }

        for(char letter : letters)
        {
            if(letter>target )
            {
                return letter;
            }
        }
        return letters[0];
 }
}     
    
