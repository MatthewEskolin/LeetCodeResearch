t using System;

namespace LeetCodeConsole{

    public static class _279_First_BadVersion
    {
        public static void Run()
        {


            Console.WriteLine(FirstBadVersion(2));

            // FirstBadVersion(1);
            // FirstBadVersion(1);
            // FirstBadVersion(1);
        }

        public static int FirstBadVersion(int n)
        {

            int low = 1;
            int high = n;
            int mid = -1;

            while(low != high)
            {
                mid = ((high - low) / 2) + low;
                var isBad = isBadVersion(mid);

                if(!isBad)
                {
                    //the first bad version is a higher version
                    low = mid + 1;                    
                }
                else if(isBad)
                {
                    //the first bad version is a lower version
                    high = mid;                    
                }
            }

            
            
            return low;

        }




        public static int FirstBadVersion_Attempt1(int n)
        {
            //Consider using binary search method here -
            var first = FindFlip(1,n);
            var second = FindFlip(first.Item1,first.Item2);
            return second.Item1;
        }

        public static System.Tuple<int, int> FindFlip(int low, int high)
        {

            bool flipFound = false;
            int oldMid = -1;
            int mid = -1;
                bool? prevWasBad = null;


            while(!flipFound)
            {
                oldMid = mid;
                mid = (low + high) >> 1;


                var isBad = isBadVersion(mid);
                
                if(prevWasBad != null)
                {
                    if(isBad && !prevWasBad.Value)
                    {
                        //reverse search until flip happens again
                        flipFound = true;
                        return  new Tuple<int,int>(low,mid);
                    }

                    if(!isBad && prevWasBad.Value){

                        //reverse search until flip happens again
                        flipFound = true;
                        return new Tuple<int,int>(mid,high);
                    }                
                }

                if(!isBad)
                {
                    //the first bad version is a higher version
                    low = mid + 1;                    
                    prevWasBad = false;
                }
                else if(isBad)
                {
                    //the first bad version is a lower version
                    high = mid - 1;                    
                    prevWasBad = true;
                }


            }

            throw new ArgumentException("bad data");



        }

        public static bool isBadVersion(int version)
        {
            if(version >= 2) return true;
            return false;
        }


    }
}