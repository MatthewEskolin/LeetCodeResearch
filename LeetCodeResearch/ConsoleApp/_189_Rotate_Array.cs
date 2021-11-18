using System;
using System.Diagnostics;

namespace LeetCodeResearch
{
    public static class  _189_Rotate_Array {

        public static void Run()
        {

            Console.WriteLine($"4 = {Rotate(new int[]{1,3,5,6},2)}");
            Console.WriteLine($"4 = {Rotate(new int[]{1,2,3,6},7)}");
            Console.WriteLine($"2 = {Rotate(new int[]{1,3,5,6},5)}");
            
            
        }

        public static string Rotate(int[] nums, int k) {

        
        //How can we Rotate the Array?
        
        //2 pointers
        
        // var pointer1 = 0;
        // var pointer2 = 0;
            
        var result = new int[nums.Length];

        return String.Empty;
        
        //calculate the new index based on the value of k
        
        // for(int i = 0; i < i. - 1; i++)
        // {
        //     //i / nums.Lengh;
            
        // }       


// Input: nums = [1,2,3,4,5,6,7], k = 3

// (20 / 7) = 2 -> (6)

// Output: [5,6,7,1,2,3,4]
// Explanation:
// rotate 1 steps to the right: [7,1,2,3,4,5,6]
// rotate 2 steps to the right: [6,7,1,2,3,4,5]
// rotate 3 steps to the right: [5,6,7,1,2,3,4]





        }

    }



}