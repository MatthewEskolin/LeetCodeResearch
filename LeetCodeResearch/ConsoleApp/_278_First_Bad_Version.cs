using System;
namespace LeetCodeResearch
{
    public static class _279_First_BadVersion
    {
        public static void Run()
        {
            Console.WriteLine(FirstBadVersion(2));
        }
        public static int FirstBadVersion(int n)
        {

            int low = 1;
            int high = n;
            int mid = -1;

            while (low != high)
            {
                mid = ((high - low) / 2) + low;
                var isBad = isBadVersion(mid);

                if (!isBad)
                {
                    //the first bad version is a higher version
                    low = mid + 1;
                }
                else if (isBad)
                {
                    //the first bad version is a lower version
                    high = mid;
                }
            }

            return low;
        }
        public static bool isBadVersion(int version)
        {
            if (version >= 2) return true;
            return false;
        }
    }
}