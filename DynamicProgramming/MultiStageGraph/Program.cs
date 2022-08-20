using System;
namespace CodingChallenges
{
    class Program
    {
        public static void Main()
        {
            //Step 1: Represent multistage graph in 2d array. 
            int[,] MultiStageGraph = {  {0,9,7,5,0,0,0,0,0,0,0,0},
                                         {9,0,0,0,3,5,6,0,0,0,0,0},
                                         {7,0,0,0,0,4,5,7,0,0,0,0},
                                         {5,0,0,0,0,0,2,7,0,0,0,0},
                                         {0,3,0,0,0,0,0,0,5,2,0,0},
                                         {0,5,4,0,0,0,0,0,0,4,8,0},
                                         {0,6,5,2,0,0,0,0,7,5,3,0},
                                         {0,0,7,7,0,0,0,0,0,0,7,0},
                                         {0,0,0,0,5,0,7,0,0,0,0,6},
                                         {0,0,0,0,2,4,5,0,0,0,0,4},
                                         {0,0,0,0,0,8,3,7,0,0,0,2},
                                         {0,0,0,0,0,0,0,0,6,4,2,0}};
            int stages = 5;
            int vertex = 12;
            /*     int[,] MultiStageGraph = { {0,2,1,3,0,0,0,0},
                                              {2,0,0,0,2,3,0,0},
                                              {1,0,0,0,6,7,0,0},
                                              {3,0,0,0,6,8,9,0},
                                              {0,2,6,6,0,0,0,6},
                                              {0,3,7,8,0,0,0,4},
                                              {0,0,0,9,0,0,0,5},
                                              {0,0,0,0,6,4,5,0}};
                  int stages = 4;
                  int vertex = 8;*/
            //For storing cost of vertex, initializing with Maximum to start with
            List<int> Cost = new List<int>(vertex);
            List<int> Distance = new List<int>(vertex);
            for (var item = 0; item < vertex; item++)
            {
                Cost.Add(0);
                Distance.Add(0);
            }

            List<int> Path = new List<int>(stages);
            for (var item = 0; item < stages; item++)
            {
                Path.Add(0);
            }
            //we do not need to calculate starting point and finishing point because it is already decided
            Path[0] = 1;
            Path[stages - 1] = vertex;

            //Working for each vertex, we want to skip last vertex because its cost is 0 and no need to calculate
            //that is why loop started from vertex -2, (1 to skip last vertex, 1 for 0 based index)
            for (int i = vertex - 2; i >= 0; i--)
            {
                int minimumCost = int.MaxValue;
                //find minimum cost from this vertex to all forward vertex
                for (int j = i + 1; j < vertex; j++)
                {
                    if (MultiStageGraph[i, j] != 0 && (MultiStageGraph[i, j] + Cost[j]) < minimumCost)
                    {
                        minimumCost = MultiStageGraph[i, j] + Cost[j];
                        Distance[i] = j + 1; // Adding in in Distance to convert zero based index to 1 based vertex number
                    }
                    Cost[i] = minimumCost;
                }
            }
            //Calculating shortest path
            for (int i = 1; i < stages - 1; i++)
            {
                Path[i] = Distance[Path[i - 1] - 1]; //Additional -1 to convert 0 based index to 1 based vertex value
            }
            Console.WriteLine("Cost Array");
            for (var item = 0; item < vertex; item++)
            {
                Console.Write("{0} ", Cost[item]);
            }
            Console.WriteLine("\nDistance Array");
            for (var item = 0; item < vertex; item++)
            {
                Console.Write("{0} ", Distance[item]);
            }
            Console.WriteLine("\nPath Array");
            for (var item = 0; item < stages; item++)
            {
                Console.Write("{0} ", Path[item]);
            }
        }
    }
}