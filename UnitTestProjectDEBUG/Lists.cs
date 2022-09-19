using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System;

namespace UnitTestProjectDEBUG
{
    [TestClass]
    public class Lists
    {
        [TestMethod]
        public void Test_Creating_Lists()
        {
            ArrayList myArray = new ArrayList();
            myArray.Add("Today");
            myArray.Add(2);
            myArray.Add(20);
            myArray.Add(20M);
            Console.WriteLine(myArray.Count);
            myArray.RemoveAt(3);
            Console.WriteLine(myArray.Count);

        }
        [TestMethod]
        public void Testing_Array_List()
        {
            ArrayList scores = new ArrayList();
            FillList(scores);
            int sum = TotalScores(scores);
            Console.WriteLine(sum);

        }
        public void FillList(ArrayList scores)
        {
            for (int i = 1; i<= 20; i++)
            {
                scores.Add(i);
            }
        }
        public int TotalScores(ArrayList scores)
        {
            int sum = 0;
            foreach(int score in scores)
            {
                sum += score;
            }
            return sum;
        }




        /*public int TotalScores()
        {

        }*/



    }
}
