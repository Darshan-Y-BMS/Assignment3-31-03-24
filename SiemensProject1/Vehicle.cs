using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensProject1
{
    public abstract class Vehicle : IDrawable
    {
        protected String brand;
        protected String model;
        public Vehicle(String brand, String model)
        {
            this.brand = brand;
            this.model = model;
        }
        public abstract void start();
        public abstract void stop();
        public abstract void draw();
        public void displayInfo()
        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Model: " + model);

        }
    }

}
