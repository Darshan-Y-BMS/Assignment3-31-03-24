using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensProject1
{
    public class MotorCycle : Vehicle
    {
        public MotorCycle(String brand, String model) : base(brand, model)
        {
        }
        public override void start()
        {
            Console.WriteLine("On the Motor cycle and start by giving accelerator ");
        }
        public override void stop()
        {
            Console.WriteLine("Apply hand break and lock the Motor cycle");
        }
        public override void draw()
        {
            Console.WriteLine("Draw method from MotorCycle class");
        }

    }

}
