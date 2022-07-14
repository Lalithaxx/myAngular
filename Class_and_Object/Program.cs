
/*using System;
namespace Class_and_Object
{
    class Program
    {
        static void Main(string[] args)
        {

            // Student myobj = new Student(1, 75, "yash", "raj");
            // Console.WriteLine(myobj);



            //Employee e = new Employee(1, "raj", 25000);
            //Console.WriteLine(e);

            //Employee1 e1 = new Employee1();

            /* Employee1 e = new Employee1(1, "raj", 25000 , Department.IT);
             Console.WriteLine(e);
            Console.WriteLine("count =" + Employee1.count);  */

/* Employee1[] array = new Employee1[5];
 array[0] = new Employee1(101, "Mark henry", 60000, Department.IT);
 array[1] = new Employee1(102, "James Smith", 55000, Department.Sales);
 array[2] = new Employee1(103, "Robert Smith", 50000, Department.Production);
 array[3] = new Employee1(104, "Maria Hernande", 50000, Department.Accounts);
 array[4] = new Employee1(105, "Billy Joel", 65000, Department.IT);

for (int i = 0; i < array.Length; i++)
 {
     Console.WriteLine(array[i] + "\n");
 }
*/


// Console.WriteLine($"total count of employees are {Employee1.ShowCount()}");

//  Console.WriteLine(Employee1.ShowCount());

/*       date d1 = new date(25, "May", 2022);
       Employee1 e = new Employee1(1, "yash", 100, Department.IT, d1);
       Employee1 e2 = new Employee1();
       Console.WriteLine(e2);
       Console.WriteLine(e);
       Employee1 e1 = new Employee1(2, "rahul",  200,  Department.IT ,new Date(5, "June", 2022));
       Console.WriteLine(e1);

       Console.WriteLine("\n total count: {0}", Employee1.ShowCount());

   }
}
}
*/
/*using System;
namespace class_and_object
{
    class Program
    {
        static void Main(string[] args)
        {
            /*date d1 = new date(25, "May", 2022);
            Employee1 e = new Employee1(1, "raj", "yash", 100, d1);
            Employee1 e2 = new Employee1();
            Console.WriteLine(e2);
            Console.WriteLine(e);
            Employee1 e1 = new Employee1(2, "rahul", "rawat", 200, new date(5, "June", 2022));
            Console.WriteLine(e1);
            Console.WriteLine("\n total count: {0}", Employee1.ShowCount());


            Manager m1 = new Manager();
            Manager m2 = new Manager(1000,20000,1,"raj" ,300000,department.IT ,new date(31 ,"July" , 2000);




        }
    }
}*/




using System;

namespace Abstract_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.Area(2);
            c.Colour();
        }
    }
}

