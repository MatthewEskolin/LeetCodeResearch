using System;

namespace LeetCodeResearch
{

    public class _704_Binary_Search
    {
        public static void Run()
        {

        }

        public int Search(int[] nums, int target)
        {

            int low = 0;
            int high = nums.Length - 1;


            //find index of target
            while(low < high)
            {
                var mid = ((high - low) / 2) + low;

                if(nums[mid] < target)
                {
                    low = mid + 1;
                }
                else if(nums[mid] > target)
                {
                    high = mid - 1;
                    
                }
                else if(nums[mid] == target)
                {
                    return mid;
                }

                Console.WriteLine("----------Iteration---------");

                Console.WriteLine($"low = {low}");
                Console.WriteLine($"mid = {mid}");
                Console.WriteLine($"high = {high}");
                // throw new Exception("something is not right");
            }

            return -1;


        }
    }
}