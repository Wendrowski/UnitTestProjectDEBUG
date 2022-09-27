using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOTopics
{
    class Student : Person
    {
        public string major;
        public int studentId;

        public Student(string id, string fName, string lName, int anAge, string maj, int stId )
            : base(id, fName, lName, anAge)
        {
            major = maj;
            studentId = stId;
        }

        public override string GetExerciseHabbits()
        {
            return "Zero time to exercise";
        }
    }
}
