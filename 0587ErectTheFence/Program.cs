using System;

namespace _0587ErectTheFence
{
    class Program
    {

        public int[][] OuterTrees(int[][] trees)
        {
            for (int i = 0; i < trees.Length; i++)
            {
               
                //check verticaal boven elkaar
                if(trees[i][0]== trees[i + 1][0] && trees[i][1] != trees[i+1][1])
                {
                    Console.WriteLine(trees[i][0]);
                    Console.WriteLine(trees[i][1]);
                    Console.WriteLine(trees[i + 1][0]);
                    Console.WriteLine(trees[i + 1][1]);
                }

                //check horizontaal naast elkaar
                if (trees[i][1] == trees[i + 1][1] && trees[i][0] != trees[i + 1][0])
                {
                    Console.WriteLine(trees[i][0]);
                    Console.WriteLine(trees[i][1]);
                    Console.WriteLine(trees[i + 1][0]);
                    Console.WriteLine(trees[i + 1][1]);
                }

            }
            return trees;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int[][] trees = new int[][]
            {
                new int[]{1,1},
                new int[]{2,2},
                new int[]{2,0},
                new int[]{2,4},
                new int[]{3,3},
                new int[]{4,2}
            };


            var x = p.OuterTrees(trees);
            //foreach (var i in x)
            //{
            //    foreach (var j in i)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}

        }
    }
}
