class Solution {
    public boolean isPalindrome(String s) {
        s = s.toLowerCase();
        String[] words = s.split("[^A-Za-z0-9]+");
        String result = String.join("", words);
        String sb = new StringBuilder(result).reverse().toString();
        return sb.equals(result);
    }
}
