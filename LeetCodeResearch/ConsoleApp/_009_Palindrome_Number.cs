using System;

namespace LeetCodeResearch;

public static class _009_Palindrome_Number
{
    public static void Run()
    {
        Console.WriteLine(IsPalindrome(232));
    }

    public static bool IsPalindrome(int x)
    {
        //negative numbers are not palindromes
        if(x < 0) return false;

        //numbers cannot start with 0, so numbers ending with 0 cannot be palindromes - reversing a number ending with 0 would require a number starting with zero
        //however if x = 0, this is a palindrome
        if(x % 10 == 0 && x != 0) return false;

        int reversedNumber = 0;

        while (x > reversedNumber)
        {


            //we reduce the magnitude of x by 1 each time, while increasing the magnitude of the reversed number by 1
            //                           (0) MAGx = 3, MAGreversed = 0, (123,0)
            //so if x = 123 at iteration (1) MAGx = 2, MAGreversed = 1, (12,3) 
            //                           (2) MAGx = 2, MAGreversed = 2, (1,32)
            //                           (LOOP ENDS) - in this case the 2 in the middle does not matter so we only care if 3 equals 1, which it does not
            
            reversedNumber = reversedNumber * 10 + x % 10;
            x /= 10;

        }

        var firstHalf = x;
        var secondHalf = reversedNumber;

        return firstHalf == secondHalf || firstHalf == secondHalf / 10;

    }
}