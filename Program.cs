using System;
using System.Collections.Generic;

namespace Lab4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a list that holds the scores you’ve been given.
            List<int> scoreList = new List<int>();
            scoreList.Add(4400);
            scoreList.Add(8900);
            scoreList.Add(1200);
            scoreList.Add(3700);
            scoreList.Add(7200);

            Console.WriteLine("Raw Score List Data");
            foreach (int score in scoreList)
            {
                Console.WriteLine(score);
            }

            // 2.Sort the scores lowest to highest and output to the screen.    
            scoreList.Sort();
            
            Console.WriteLine("Sorted Score List Data, Low to High");
            foreach (int score in scoreList)
            {
                Console.WriteLine(score);
            }

            // 3.Sort the scores highest to lowest and output to the screen.
            scoreList.Reverse();
            
            Console.WriteLine("Sorted Score List Data, High to Low");
            foreach (int score in scoreList)
            {
                Console.WriteLine(score);
            }

            // 4.You’ve just been given a new score that wasn’t part of the original list. Add the score 2400 to the list.
            scoreList.Add(2400);
            
            Console.WriteLine("New Data Added to Score List");
            foreach (int score in scoreList)
            {
                Console.WriteLine(score);
            }
        }
    }
}
