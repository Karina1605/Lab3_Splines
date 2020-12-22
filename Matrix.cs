using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Splines
{
    public class Matrix
    {
        public Vector _under;
        public Vector _center;
        public Vector _upper;
        double _h;
        Vector _fS;
        Func<double, double> function;
        double A, B;
        double _x0, _xN;
        int _N;
        public Vector result;
        public Matrix(double x0, double xN, int N, Func<double, double> function, double A, double B)
        {
            _h = (xN-x0)/N;
            _x0 = x0;
            _xN = xN;
            _N = N;
            this.function = function;
            this.A = A;
            this.B = B;
            _fS = new Vector(N);
            for (int i = 1; i <= N; ++i)
                _fS[i] = (function(x0+(i*_h)) - function(x0+(_h*(i-1)))) / _h;
            _center = new Vector(N);
            _under = new Vector(N - 1);
            _upper = new Vector(N - 1);
            result = new Vector(N);
        }
        public double this [int i, int j]
        {
            get
            {
                if (i <= 0 || j <= 0 || i > _center.Dimension || j > _center.Dimension)
                    throw new IndexOutOfRangeException();
                if (i == j)
                    return _center[i];
                if (i - j == 1)
                    return _under[j];
                if (j - i == 1)
                    return _upper[i];
                return 0;
            }
        }
        public void FillMatrix()
        {
            _center[1] = /*1;*/ 14*_h;
            _upper[1] = /*0;*/ 4 * _h;
            for (int i=2; i<=_center.Dimension-1; ++i)
            {
                _under[i - 1] = 1;
                _center[i] = 4;
                _upper[i] = 1;
            }
            _under[_center.Dimension - 1] = 1;
            _center[_center.Dimension] = 2;

        }
        public void FillResult()
        {
            result[1] =/* 3*(_x0+_h)*(_x0+_h);*/A * _h * _h - function(_x0+_h)*6 + 12*function(_x0+(2*_h)) -6*function(_x0);
            result[result.Dimension] = ((B * _h) / 2) + 3 * (_fS[_fS.Dimension]);
            for (int i = 2; i <= result.Dimension - 1; ++i)
                result[i] = 3*(_fS[i]+_fS[i+1]);
        }
        public Matrix GetCopy()
        {
            Matrix matrix = new Matrix(_x0, _xN, _N, function, A, B);
            matrix.FillMatrix();
            matrix.FillResult();
            return matrix;
        }
        public Vector Solve()
        {
            Vector res = Vector.Copy(result);
            for (int i=1; i<_center.Dimension; ++i)
            {
                double b = 1/ _center[i];
                _center[i] = 1;
                _upper[i] *= b;
                res[i] *= b;

                b = -_under[i];
                _under[i] = 0;
                _center[i + 1] += (_upper[i] * b);
                res[i + 1] += (res[i] * b);
            }
            double n = 1 / _center[_center.Dimension];
            _center[_center.Dimension] = 1;
            res[_center.Dimension] *= n;

            for (int i = _center.Dimension; i >1; --i)
            {
                double b = -_upper[i-1];
                _upper[i - 1] = 0;
                res[i - 1] += (res[i] * b);
            }
            return res;
        }
    }
}
