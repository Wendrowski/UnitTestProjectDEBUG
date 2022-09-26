using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedOOTopics
{
    [TestClass]
    public class InheritanceTest
    {
        [TestMethod]
        public void Check_Person_Student_Relationship()
        {
            Person myPerson = new Person("1234", "Baker", "Sarah", 24);

            Student myStudent = new Student("1111", "Bob", "Baker", 26, "Computer Science", 9999);

        }
    }
}
