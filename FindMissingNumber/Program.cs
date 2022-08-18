namespace CodingChallenges
{
    class Program
    {
        public static void Main()
        {
            List<int> arr = new List<int> { 3, 7, 1, 2, 8, 4, 5 };


            //Using sort in-build function
            arr.Sort();
            for (int index = 1; index <= arr.Count(); index++)
            {
                if (index != arr[index - 1])
                {
                    Console.WriteLine("Missing item is {0}", index);
                    break;
                }
            }

            //Without any in-build function
            int arrLength = arr.Count()+1;
            int correctSum = (arrLength * (arrLength + 1)) / 2;
            int actualSum = 0;
            for (int index = 0; index < arr.Count(); index++)
            {
                actualSum = actualSum + arr[index];
            }
            Console.WriteLine("Missing item is {0}", (correctSum-actualSum));
        }
    }
}