// public class Solution {
//     public int LengthOfLongestSubstring(string s) {

//     HashSet<char> map = new HashSet<char>();

//             int left = 0;
//             int maxLength = 0;
//             for(int right = 0; right <s.Length; right++)
//             {
//                while(map.Contains(s[right]))
//                {
//                 map.Remove(s[left]);
//                 left++ ;
//                }

//                map.Add(s[right]);

//                maxLength = Math.Max(maxLength, right-left + 1);
//             }

//            return maxLength;
//     }
// }
public class Solution {
public int LengthOfLongestSubstring(string s)
{
    Dictionary<char, int> map = new Dictionary<char, int>();

    int left = 0;
    int maxLength = 0;

    for (int right = 0; right < s.Length; right++)
    {
        char current = s[right];

        // if duplicate found, move left pointer
        if (map.ContainsKey(current) && map[current] >= left)
        {
            left = map[current] + 1;
        }

        // update last seen index
        map[current] = right;

        // update max length
        maxLength = Math.Max(maxLength, right - left + 1);
    }

    return maxLength;
}
}
