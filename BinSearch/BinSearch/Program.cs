using System;

namespace BinSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[7] {1,2,3,4,5,6,7 };
            int search = 1;
            if (BinSearch(arr, search))
            {
                Console.WriteLine("Number "+search+" is found" );
            }
            else
            {
                Console.WriteLine("Number " + search + " is NOT found");
            }     

        }


        public static bool BinSearch(int [] arr,int x)
        {
            int left = 0;
            int right = arr.Length - 1;
            int med;
            while (left < right)
            {            
                med = (left + right) / 2;
                if (arr[med] >= x)
                {
                    right = med;
                }
                else{
                    left = med + 1;
                }
                if (arr[left] == x)
                {
                    return true;
                } 

            }
            return false;
        }
    }
}
