
/*using System;
namespace Class_and_Object
{
    public enum Department { IT, Production, Sales, Civil, Accounts }//labeled integer 
    class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Department dept { get; set; }
        public static int count { get; set; }
        public date dateofjoining;
        // default constructor
        public Employee1()
        {
            Id = 10001;
            Name = "bill Gates";
            Salary = 1000000;
            dept = Department.IT;
            dateofjoining d = new date();
            count++;
        }


        // static constructor 
        static Employee1()
        {
            count = 100;
            Console.WriteLine(" This is Static Constructor :");
        }
        // parametersied constructor 
        public Employee1(int id, string name, decimal sal, Department dept , Date doj)
        {
            Id = id;
            Name = name;
            Salary = sal;
            this.dept = dept;
            dateofjoining = doj;


        }
        public override string ToString()
        {
            return "Id : " + Id + Name + " " + Salary + " Department :" + dept + " Date is " + Date;
        }

        public static  int ShowCount()
        {
            return count;
        }

    }

 }*/
using System;
using System.Collections.Generic;
using System.Text;

namespace class_and_object
{
    public enum department { IT, HR, Data_Analytics };

    class Employee1
    {
        public int emp_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int salary { get; set; }

        public date dateofjoining;

        public static int count;

        public department dept;

        static Employee1()
        {
            count = 0;
            Console.WriteLine("This is it");
        }
        public Employee1()
        {
            emp_id = 0;
            firstname = "Defaultname";
            lastname = "Defaultlastname";
            salary = 0;
            this.dept = department.IT;

            dateofjoining = new date();
            count++;
        }
        public Employee1(int id, string fname, string lname, int sal, date doj)
        {
            emp_id = id;
            firstname = fname;
            lastname = lname;
            salary = sal;
            dateofjoining = doj;
            count++;
        }

        public static int ShowCount()
        {
            return count;
        }

        public override string ToString()
        {
            return "Name:" + firstname + " " + lastname + "\n salary: " + salary + "\n id: " + emp_id + "\ndate of joining: " + dateofjoining;
        }


        public virtual void grosssalary()
        {
            decimal gross = salary + salary + 0.7m + Commission + salary;
        }

    }
}