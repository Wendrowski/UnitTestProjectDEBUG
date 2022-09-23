using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

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
        [TestMethod]
        public void ArrayList_Practice()
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("Adding some numbers: ");
            list.Add(45);
            list.Add(78);
            list.Add(33);
            list.Add(56);
            list.Add(12);
            list.Add(23);
            list.Add(9);

            Console.WriteLine("Capacity: {0}", list.Capacity);
            Console.WriteLine("Count: {0} ", list.Count);

            Console.WriteLine("Content: ");
            foreach (int i in list)
            {
                Console.WriteLine(i + " ");
                Console.WriteLine();
            }

            Console.WriteLine("Sorted Content: ");
            list.Sort();
            foreach (int i in list)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();            
        }
        [TestMethod]
        public void ListCreator()
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            Console.WriteLine(list.Count);
            Console.WriteLine(list[0] + list[2]);

            List<int> list2 = new List<int>(list) { 5 };
            Console.WriteLine(list2[3]);
            list2.Add(69);
            Console.WriteLine(list2[4]);
            list2.Remove(1);
            Console.WriteLine(list2[0]);
            list2.Reverse();
            Console.WriteLine(list2[0]);

            foreach(int i in list2)
            {
                Console.WriteLine(i);
            }
        }
    }
}