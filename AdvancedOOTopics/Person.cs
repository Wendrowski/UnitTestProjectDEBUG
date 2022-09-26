using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdvancedOOTopics
{
    [TestClass]
     class Person
    {
        private string idNumber;
        private string lastName;
        private string firstName;
        private int age;

        public Person()
        {

        }
        public Person(string id, string lName, string fName, int anAge)
        {
            firstName = fName; 
            age = anAge;
            idNumber = id;
            lastName = lName;

        }
    }
}
