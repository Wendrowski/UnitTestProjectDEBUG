using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace UnitTestProjectDEBUG
{
    [TestClass]
    public class SectionExam
    {
        [TestMethod]
        public static void Main()
        {
            ArrayList dataList = new ArrayList();
            dataList.Add("Someday");
            dataList.Add(2);
            dataList.Add("App");
            dataList.Add(13.5);
            dataList.Add("Red");
            dataList.Add(8);
            dataList.Add(99);
            dataList.Add("6");
            dataList.Add("Meatball Soup");
            dataList.Add(18M);
            dataList.Add("Pieces");
            dataList.Add(14);

            ArrayList goodValues = CheckList(dataList);

            int sum = SumList(goodValues);

            Assert.AreEqual(147, sum);
        }
        public static ArrayList CheckList(ArrayList list)
        {
            ArrayList goodVals = new ArrayList();
            
            foreach (var item in list)
            {
                int aValue;

                if(int.TryParse(Convert.ToString(item), out aValue) == true)
                {
                    goodVals.Add(aValue);
                }
            }
            return goodVals;
        }
        public static int SumList(ArrayList list)
        {
            int sum = 0;

            foreach(int item in list)
            {
                sum += item;
            }
            return sum;
        }
    }
}
