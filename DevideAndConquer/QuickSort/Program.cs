namespace CodingChallenges
{
    class Program
    {
        public static void Main()
        {
            List<int> arr = new List<int> { 10, 16, 8, 12, 15, 6, 3, 9, 5 };
            var SortedArray = QuickSort(arr, 0, arr.Count() - 1);

            foreach (var item in SortedArray)
            {
                Console.WriteLine("Array Item {0}", item);
            }
        }


        public static List<int> QuickSort(List<int> ListData, int LeftIndex, int RightIndex)
        {
            var i = LeftIndex;
            var j = RightIndex;
            var pivot = ListData[LeftIndex];

            //Search for element greater than pivot from beginning of array

            while (i < j)
            {
                do
                {
                    i++;
                }
                while (pivot >= ListData[i]);


                //search for element less than pivot from end of array
                while (pivot < ListData[j])
                {
                    j--;
                }


                // find position to swap
                if (i < j)
                {
                    int temp1 = ListData[i];
                    ListData[i] = ListData[j];
                    ListData[j] = temp1;
                }
            }
            int temp = ListData[j];
            ListData[j] = ListData[LeftIndex];
            ListData[LeftIndex] = temp;

                        if (LeftIndex < j)
                            QuickSort(ListData, LeftIndex, j);
                        if (i < RightIndex)
                            QuickSort(ListData, i, RightIndex);
            return ListData;
        }
    }
}