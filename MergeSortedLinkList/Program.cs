using System.Collections.Generic;
namespace CodingChallenges
{
    class Program
    {
        public static void Main()
        {

            LinkedList<int> List1 = new LinkedList<int>();
            List1.AddLast(4);
            List1.AddLast(8);
            List1.AddLast(15);
            List1.AddLast(19);

            LinkedList<int> List2 = new LinkedList<int>();
            List2.AddLast(7);
            List2.AddLast(9);
            List2.AddLast(10);
            List2.AddLast(16);
            List2.AddLast(20);


            //Merging lists
            var MergedList = MergeLinkedList(List1, List2);
            foreach (var item in MergedList)
            {
                Console.WriteLine("Found values: {0}", item);
            }
        }

        static LinkedList<int> MergeLinkedList(LinkedList<int> List1, LinkedList<int> List2)
        {
            if (List1.Count() == 0)
            {
                return List2;
            }
            if (List2.Count() == 0)
            {
                return List1;
            }

            LinkedList<int> MergedList = new LinkedList<int>();
            while (List1.Count() > 0 && List2.Count() > 0)
            {
                if (List1.First!.Value <= List2.First!.Value)
                {
                    MergedList.AddLast(List1.First!.Value);
                    List1.RemoveFirst();
                }
                else
                {
                    MergedList.AddLast(List2.First!.Value);
                    List2.RemoveFirst();
                }
            }
            while (List1.Count() > 0)
            {
                MergedList.AddLast(List1.First!.Value);
                List1.RemoveFirst();
            }
            while (List2.Count() > 0)
            {
                MergedList.AddLast(List2.First!.Value);
                List2.RemoveFirst();
            }
            return MergedList;
        }
    }
}