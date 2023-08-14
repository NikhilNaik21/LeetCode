# Intuition
<!-- Describe your first thoughts on how to solve this problem. -->

# Approach
<!-- Describe your approach to solving the problem. -->

# Complexity
- Time complexity:
<!-- Add your time complexity here, e.g. $$O(n)$$ -->

- Space complexity:
<!-- Add your space complexity here, e.g. $$O(n)$$ -->

# Code
```
class Solution {
    public double findMedianSortedArrays(int[] nums1, int[] nums2) {
        int size = nums1.length + nums2.length;
    int [] nums3 = new int [size];
     int k =0;
     double median;
     
        for(int i=0;i<nums1.length;i++)
        {
            
            nums3[k] = nums1[i];
            k++;
        }

         for(int j=0;j<nums2.length;j++)
        {
            
            nums3[k] = nums2[j];
           k++;
        }

        Arrays.sort(nums3);
        if(nums3.length %2!=0)
        {

        
         median = nums3[size/2];
             return median;
        }
        else{
             median =(double) (nums3[size/2-1] + nums3[size/2])/2;
            return median;
        }
    }
   
}
```
