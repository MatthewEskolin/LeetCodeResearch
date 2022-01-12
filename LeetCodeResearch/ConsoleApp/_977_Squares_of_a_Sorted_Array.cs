using System;

namespace LeetCodeResearch
{
    public class _977_Squares_of_a_Sorted_Array
    {
        //Author Test
        // Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
        // Example 1:

        // Input: nums = [-4,-1,0,3,10]
        // Output: [0,1,9,16,100]
        // Explanation: After squaring, the array becomes [16,1,0,9,100].
        // After sorting, it becomes [0,1,9,16,100].
        // Example 2:

        // Input: nums = [-7,-3,2,3,11]
        // Output: [4,9,9,49,121]


        // Constraints:

        // 1 <= nums.length <= 104
        // -104 <= nums[i] <= 104
        // nums is sorted in non-decreasing order.

        public static void Run()
        {
            var result = SortedSquares(new int[] { -4, -1, 0, 3, 10 });
            var arrayString = string.Join(", ", result);
            Console.WriteLine($"{arrayString}");

        }


        public static int[] SortedSquares(int[] nums)
        {
            int n = nums.Length;
            int left = 0;
            int right = n - 1;

            int[] result = new int[n];

            //{ -4, -1, 0, 3, 10 }
            //left = 0  - (-4)
            //right = 4 - (10) 

            //RESULT
            //result[4] = 100
            //result[3] = 16
            //result[2] = 9
            //result[1] = 1
            //result[0] = 0 


            for (int index = n - 1; index >= 0; index--) {


                if (Math.Abs(nums[left]) > nums[right])
                {
                    result[index] = (int)Math.Pow(nums[left],2);
                    left++;
                }
                else
                {
                    result[index] = (int)Math.Pow(nums[right],2);
                    right--;
                }
            }

            return result;


        }

    }
}
