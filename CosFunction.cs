using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Splines
{
    class CosFunction : IFunction
    {
        public double getY(double x)
        {
            return Math.Cos(x);
        }
    }
}
