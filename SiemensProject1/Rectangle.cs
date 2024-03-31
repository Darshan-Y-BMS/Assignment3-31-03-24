using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensProject1
{
    public class Rectangle : IShape
    {
        public float length;
        public float breadth;

        public Rectangle(float length, float breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public void getDetails()
        {
            Console.WriteLine($"The rectangle is of Length {length} unit and breadth {breadth} unit");
        }
        public void draw()
        {

            Console.WriteLine($"Drawing a  rectangle is of Length {length} unit and breadth {breadth} unit");
        }

        public double getArea()
        {
            return length * breadth;
        }
        public double getPerimeter()
        {
            return (length + breadth) * 2;
        }
    }

}
