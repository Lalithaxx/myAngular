using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_practice
{
    public class Circle : Shape
    {
        public override void Area(int r)
        {
            Console.WriteLine(3.14 * r * r);
        }
    }
}