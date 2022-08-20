namespace CodingChallenges
{
    class Program
    {
        public static void Main()
        {
            int Index = 18;
            List<int> Tabulation = new List<int>(Index);
            for (int i = 0; i < Index; i++)
            {
                Tabulation.Add(int.MinValue);
            }
            // Calling with minus 1 because array Index start with 0
            int ZeroBasedIndex = Index - 1;
            FibonacciSequence(ZeroBasedIndex, Tabulation);
            Console.WriteLine("Value at {0} on Fibonacci Sequence is {1}", Index, Tabulation[ZeroBasedIndex]);
        }
        public static int FibonacciSequence(int ZeroBasedIndex, List<int> Tabulation)
        {
            //Index = Index - 1;
            if (ZeroBasedIndex <= 1)
            {

                return ZeroBasedIndex;
            }
            Tabulation[0] = 0;
            Tabulation[1] = 1;
            for (int i = 2; i <= ZeroBasedIndex; i++)
            {
                Tabulation[i] = Tabulation[i - 2] + Tabulation[i - 1];
            }
            return Tabulation[ZeroBasedIndex];
        }
    }
}