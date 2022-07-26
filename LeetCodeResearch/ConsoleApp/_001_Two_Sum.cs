namespace LeetCodeResearch;

public class _001_Two_Sum
{
    public int[] TwoSum(int[] nums, int target)
    {

        //Two Pass Hash Table

        //(1)
        //Generate Hash Table by Iterating num and storing as <Key = nums[i] -> Val = i>
        var dict_val_index = new System.Collections.Generic.Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(dict_val_index.ContainsKey(nums[i]))
            {
                dict_val_index[nums[i]] = i;
            }   
            else
            {                        
                dict_val_index.Add(nums[i],i);       
            }                 
                                
        }

        //(2)
        //Go through the nums array again. The Key step is to pre-compute the complement and then look for it
        for(int i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
                    
            //must exclude current index, as we must use two values added together to get target - we can't use the same value for both addend and 
            if(dict_val_index.ContainsKey(complement) && dict_val_index[complement] != i)
            {
                return new int[]{i, dict_val_index[complement]};                       
            }
        }

        return null;

    }
            

}