using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Web;


#pragma warning restore format
namespace LeetCodeResearch
{
    class Program
    {
        static void Main(string[] args)
        {




for(int i = 1; i < 10000; i++)
{
    using (var rng = new RNGCryptoServiceProvider())
    {
        var bit_count = (20 * 6);
        var byte_count = ((bit_count + 7) / 8); // rounded up
        var bytes = new byte[byte_count];
        rng.GetBytes(bytes);
        Console.WriteLine( Convert.ToBase64String(bytes));

        //return
    }

}

        }



    }

    public class App
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
}
