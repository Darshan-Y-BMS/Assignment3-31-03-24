using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensProject1
{
    public class Circle : IShape
    {
        protected float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }
        public void getDetails()
        {
            Console.WriteLine("The Circle is of Radius  " + radius + "units");
        }
        public void draw()
        {
            Console.WriteLine("Drawing a circle of radius " + radius);
        }
        public double getArea()
        {
            return Math.Pow(radius, 2) * Math.PI;

        }
        public double getPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

}
