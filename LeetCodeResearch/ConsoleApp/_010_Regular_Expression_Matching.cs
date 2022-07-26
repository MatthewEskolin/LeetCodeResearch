using System;
using System.Linq;

namespace LeetCodeResearch;

//https://leetcode.com/problems/regular-expression-matching/
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

    private static bool IsMatchNoStars(string s, string p)
    {
        if (String.IsNullOrEmpty(p))
        {
            return string.IsNullOrEmpty(s);
        }

        var firstMatch = p[0] == s[0] || p[0] == '.';

        var newS = s.ElementAtOrDefault(0) == null;

        return firstMatch && IsMatchNoStars(s[1].ToString(), p[1].ToString());



    }
    
}