using System;

namespace Class_and_Object
{
    class Student
    {
        int id, marks;
        string firstname, lastname;
        public Student(int id, int marks, string fname, string lname)
        {
            this.id = id;
            this.marks = marks;
            this.firstname = fname;
            this.lastname = lname;
        }


        public override string ToString()
        {
            return "Name : " + this.firstname + " " + this.lastname + "\nmarks : " + this.marks + "\n id:" + this.id;
        }

        public Student() { }

    }
}



