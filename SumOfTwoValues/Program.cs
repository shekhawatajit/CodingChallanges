using System.Collections.Generic;
namespace CodingChallenges
{
    class Program
    {
        public static void Main()
        {
            int targetSum = 10;
            List<int> arr = new List<int> { 5, 7, 1, 2, 8, 4, 3 };


            //Without any in-build function
            HashSet<int> myHash = new HashSet<int>();
            for (int index = 0; index < arr.Count(); index++)
            {
                if (myHash.Contains(targetSum - arr[index]))
                {
                    Console.WriteLine("Found values: {0}+{1}={2}", (targetSum - arr[index]), arr[index], targetSum);
                }
                myHash.Add(arr[index]);
            }
        }
    }
}