using System;
using System.Linq;

namespace LeetCodeResearch;

//https://leetcode.com/problems/regular-expression-matching/

//C# Help
//https://leetcode.com/problems/regular-expression-matching/discuss/425444/C-Solution



public static class _010_Regular_Expression_Matching
{
    public static void Run()
    {
        //IsMatch("aaaaaaaaab", "aa*b");

        //WithoutStars
        IsMatchNoStars()

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