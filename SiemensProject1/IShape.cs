using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensProject1
{
    
    public interface IShape : IDrawable
    {
        double getArea();
        double getPerimeter();
        void getDetails();
    }
}
