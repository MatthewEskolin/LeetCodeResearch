using System;
using System.Linq;

namespace LeetCodeResearch;

//https://leetcode.com/problems/regular-expression-matching/

//C# Help
//https://leetcode.com/problems/regular-expression-matching/discuss/425444/C-Solution

public static class _003_Longest_Substring_Without_Repeating_Characters
{
    public static void Run()
    {
        // Input: s = "abcabcbb"
        // Output: 3
        // Explanation: The answer is "abc", with the length of 3.
        Console.WriteLine(LengthOfLongestSubstring("Test"));
    }

    public static int LengthOfLongestSubstring(string s) {

        return 5;
        
    }

}

public static class _010_Regular_Expression_Matching
{
    public static void Run()
    {
        //IsMatch("aaaaaaaaab", "aa*b");

        //WithoutStars
        IsMatchNoStars("test","test");

    }

    private static bool IsMatch(string s, string p)
    {
        return false;

    }

    //Understanding Recursion
    private static bool IsMatchNoStars(string s, string p)
    {
        if (String.IsNullOrEmpty(p))
        {
            return string.IsNullOrEmpty(s);
        }

        bool firstMatch = p[0] == s[0] || p[0] == '.';


        string Slice(string wholeString) => wholeString.Length == 1 ? null : wholeString.Substring(1);

        return firstMatch && IsMatchNoStars(Slice(s), Slice(p));



    }
    
}