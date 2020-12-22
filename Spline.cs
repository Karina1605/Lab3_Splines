using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Splines
{
    public class Spline : IFunction
    {

        public Vector _a, _b, _c, _d;
        double[] X, Y;
        double _h;
        double _x0, _xN;
        int N;
        double A, B;
        public Matrix _m;
        Func<double, double> Func;
        public double getY(double x)
        {
            int i = Convert.ToInt32(Math.Floor((x - _x0) / _h + 1));
            double dx = x - X[i];
            return _a[i] + _b[i] * dx + _c[i] * dx * dx + _d[i] * dx * dx * dx;
        }
        private void FillXy()
        {
            X = new double[N + 1];
            Y = new double[N + 1];
            for (int i = 0; i < N + 1; i++)
            {
                X[i] = _x0 + _h * i;
                Y[i] = Func(X[i]);
            }
        }
        public Spline (double x0, double xn, int N, Func<double, double> y, double A, double B)
        {
            this.A = A;
            this.B = B;
            this.N = N;
            _x0 = x0;
            _xN = xn;
            Func = y;
            _h = (xn - x0) / N;
            _a = new Vector(N);
            FillXy();    
            for (int i=1; i<=N; ++i)
            {
                _a[i] = Y[i];
            }
        }
        void GetB()
        {
            Matrix matrix = new Matrix(_x0, _xN, N, Func, A, B);
            _m = matrix.GetCopy();
            matrix.FillMatrix();
            matrix.FillResult();
            _b = matrix.Solve();
        }
        void Fill_C()
        {
            _c = new Vector(_a.Dimension);
            _c[1] = ((3 * _a[2]) / (_h * _h)) - ((3 * _a[1]) / (_h * _h)) - (_b[2] / _h) - ((2 * _b[1]) / _h);
            for (int i = 2; i <= N; ++i)
                _c[i] = (3 * ((_a[i - 1] - _a[i]) / (_h * _h))) + ((2 * _b[i] + _b[i - 1]) / _h);
        }
        void Fill_D()
        {
            _d = new Vector(_a.Dimension);
            _d[1] = ((((3) * _a[2]) - (2 * _a[1]) - Func(_x0)) / (_h * _h * _h)) -
                ((3 * _b[1] + _b[2]) / (_h * _h));
            _d[2] = (_b[1] + _b[2]) / (_h * _h) + (2*(_a[1]-_a[2])) / (_h * _h * _h);
            for (int i = 3; i <= N; ++i)
                _d[i] = (_c[i] - _c[i - 1]) / (3 * _h);
            
        }

        public Tuple<List<double>, List<double>> GetNeedCoordinates()
        {
            List<double> x_coord = new List<double>();
            List<double> y_coord = new List<double>();
            double h = _h/ 20;
            for (int i=0; i<N; ++i)
            {
                double curr_x = _x0 + _h * i;
                x_coord.Add(curr_x);
                y_coord.Add(Func(curr_x));
                for (int j = 1; j<20; ++j)
                {
                    x_coord.Add(curr_x+h*j);
                    y_coord.Add(Func(curr_x + h * j));
                }
            }
            return new Tuple<List<double>, List<double>>(x_coord, y_coord);
        }
        public Tuple<List<double>, List<double>> GetRealCoordinates()
        {
            List<double> x_coord = new List<double>();
            List<double> y_coord = new List<double>();
            double h = _h / 20;

            for (int i = 0; i < N; ++i)
            {
                double curr_x = _x0 + _h * i;
                x_coord.Add(curr_x);
                y_coord.Add(Func(curr_x));
                for (int j = 1; j < 20; ++j)
                {
                    x_coord.Add(curr_x + h * j);
                    y_coord.Add(getY(curr_x + h * j));
                }
            }
            return new Tuple<List<double>, List<double>>(x_coord, y_coord);
        }
        public static Spline GetSpline(double x0, double xn, int N,  Func<double, double> y, double A, double B)
        {
            Spline spline = new Spline(x0, xn, N, y, A, B);
            spline.GetB();
            spline.Fill_C();
            spline.Fill_D();
            return spline;
        }
        public Tuple<List<double>, List<double>> GetError(List<double> RealCoord, List<double> CalculatedCoords, List<double> XCoords)
        {
            List<double> errors = new List<double>();
            double min = RealCoord.ElementAt(0) - CalculatedCoords.ElementAt(0);
            for (int i=0; i<RealCoord.Count; ++i)
            {
                if (Math.Abs(RealCoord.ElementAt(i) - CalculatedCoords.ElementAt(i)) < min)
                    min = Math.Abs(RealCoord.ElementAt(i) - CalculatedCoords.ElementAt(i));
                errors.Add(Math.Abs(RealCoord.ElementAt(i) - CalculatedCoords.ElementAt(i)));
            }
            System.Windows.Forms.MessageBox.Show("min = " + min);
            return new Tuple<List<double>, List<double>>(XCoords, errors);
        }
        
    }
}
