using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Splines
{
    class SqrtFunction : IFunction
    {
        public double getY(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
