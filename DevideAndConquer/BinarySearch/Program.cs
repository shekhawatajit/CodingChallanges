namespace CodingChallenges
{
    class Program
    {
        public static void Main()
        {
            List<int> arr = new List<int> { 3, 7, 1, 2, 8, 4, 5 };
            int Item = 8;
            //Using sort in-build function
            arr.Sort();
            int Index = BinarySearchLoop(arr, Item, 0, arr.Count() - 1);

            Console.WriteLine("Item found at {0} Index", Index);
        }
        public static int BinarySearchLoop(List<int> ListData, int ItemToSearch, int low, int high)
        {
            int Index = -1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (ListData[mid] == ItemToSearch)
                {
                    return mid;
                }
                else if (ListData[mid] > ItemToSearch)
                { //Means item could be on left, we need to move high pointer 
                    high = mid - 1;
                }
                else if (ListData[mid] < ItemToSearch)
                { //Means item could be on right, we need to move low pointer
                    low = mid + 1;
                }
            }

            return Index;
        }


        public static int BinarySearchRecursive(List<int> ListData, int ItemToSearch, int low, int high)
        {
            int Index = -1;
            if (low > high)
                return Index;
            int mid = (low + high) / 2;
            if (ListData[mid] == ItemToSearch)
            {
                Index = mid;
            }

            else if (ListData[mid] > ItemToSearch) // Its mean ItemToSearch is on left side
            {
                Index = BinarySearchRecursive(ListData, ItemToSearch, low, mid - 1);
            }
            else if (ListData[mid] < ItemToSearch) // Its mean ItemToSearch is on right side
            {
                Index = BinarySearchRecursive(ListData, ItemToSearch, mid + 1, high);
            }

            return Index;
        }

    }

}