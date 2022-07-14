using System;
namespace Class_and_Object
{
    public class Employee
    {
        public int id { get; set; }
        string name { get; set; }
        int salary { get; set; }
        public static int count = 0;

        public Employee(int id , string name , int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            count++;
        }

        public override string ToString()
        {
            return "Name : " + this.name + " " +"\nid : " + this.id + "\nsalary: " + this.salary ;
        }
        public static void showCount()
        {
            Console.WriteLine(count);
        }
         
      
    }
}
