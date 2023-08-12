using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private string personName;
        private int personAge;
        private int personId;

        public Student(string name, int age)
        {
            personName = name;
            personAge = age;
        }

        public Student()
        {
                                   
        }
        public string Name
        {
            get { return personName; }
            set { personName = value; }
        }
        public int Age
        {
            get { return personAge; }
            set { personAge = value; }
        }
    }
}