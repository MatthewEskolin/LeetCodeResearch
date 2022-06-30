using System;
using System.Diagnostics;

namespace LeetCodeResearch
{
    public static class _9_Palindrome_Number
    {
        public static void Run()
        {
            Console.WriteLine(IsPalindrome(232));
        }

        public static bool IsPalindrome(int x)
        {
            if(x < 0) return false;

            return false;

        }
    }
    public static class  _35_Search_Insert_Position {

        public static void Run()
        {

            // Debug.Assert(SearchInsert(new int[]{1,3,4,6},5) == 5);
            // Debug.Assert(SearchInsert(new int[]{1,3,4,6},5) == 1);

            Console.WriteLine($"4 = {SearchInsert(new int[]{1,3,5,6},2)}");
            Console.WriteLine($"4 = {SearchInsert(new int[]{1,2,3,6},7)}");
            Console.WriteLine($"2 = {SearchInsert(new int[]{1,3,5,6},5)}");
            
            
        }

        public static int SearchInsert(int[] nums, int target) {

            int low = 0;
            int high = nums.Length - 1;
            int mid = -1;

            //find index of target
            while(low <= high)
            {
                mid = ((high - low) / 2) + low;

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

            return low;


        }

    }



}