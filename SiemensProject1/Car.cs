using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensProject1
{
    public class Car : Vehicle
    {
        public Car(String brand, String model) : base(brand, model)
        {
        }
        public override void start()
        {
            Console.WriteLine("Open the lock and start the car by accelerating ");
        }
        public override void stop()
        {
            Console.WriteLine("Apply the break and lock the car");
        }
        public override void draw()
        {
            Console.WriteLine("Draw method from Car class");
        }
    }

}
