package com.Day1Pune;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class Solution {
    public List<List<Integer>> groupThePeople(int[] groupSizes) {
       
        List<List<Integer>>result = new ArrayList<>();
         HashMap<Integer, ArrayList<Integer>> group = new HashMap<>();
         for(int i=0;i<groupSizes.length;i++)
         {
             ArrayList<Integer> list = group.getOrDefault(groupSizes[i], new ArrayList<>());
             group.put(groupSizes[i] ,list);
             list.add(i);

             if(list.size() == groupSizes[i] )
             {
                 result.add(new ArrayList<>(list));
                     group.put(groupSizes[i], new ArrayList<>());
             }
         }
         return result;
       }
    
	public static void main(String[] args) {
		
        Solution solution = new Solution();

        
        int[] groupSizes = {3, 3, 3, 3, 2, 2, 2, 1, 1, 1};
        List<List<Integer>> result1 = solution.groupThePeople(groupSizes);

        
        for (List<Integer> group : result1) {
            System.out.println(group);
        }
		
	}

}
