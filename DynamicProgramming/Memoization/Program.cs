namespace CodingChallenges
{
    class Program
    {
        public static void Main()
        {
            int Index = 1;
            List<int> Memoization = new List<int>(Index);
            for (int i = 0; i < Index; i++)
            {
                Memoization.Add(int.MinValue);
            }
            // Calling with minus 1 because array Index start with 0
            int ZeroBasedIndex = Index-1;
            FibonacciSequence(ZeroBasedIndex, Memoization);
            Console.WriteLine("Value at {0} on Fibonacci Sequence is {1}", Index, Memoization[ZeroBasedIndex]);
        }
        public static int FibonacciSequence(int Index, List<int> Memoization)
        {
            //Index = Index - 1;
            if (Index <= 1)
            {
                Memoization[Index] = Index;
                return Memoization[Index];
            }
            //Index start from Zero so we need to make correction
            
            // Already calculated and no need to calculate again
            if (Memoization[Index] != int.MinValue)
                return Memoization[Index];


            else
                Memoization[Index] = FibonacciSequence(Index - 2, Memoization) + FibonacciSequence(Index - 1, Memoization);
            return Memoization[Index];
        }
    }
}