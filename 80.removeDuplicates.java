class Solution {
    public int removeDuplicates(int[] nums) {
        int count=1;
        int r =1;

         if (nums.length <= 2) {
            return nums.length; 
        }
        for(int i=1;i<nums.length;i++)
        {
            if(nums[i]==nums[i-1])
            {
                r++;
            }
            else{
                r=1;
            }

               if (r <= 2) {
                nums[count] = nums[i]; 
                count++;
            }
          }


        return count;
    }
}
