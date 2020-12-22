using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab3_Splines
{
    public partial class Form1 : Form
    {
        Func<double, double>[] functions;
        RadioButton[] buttons;
        Series seriesReal = new Series("Created spline");
        Series seriesNeed = new Series("Real graphic");
        Series seriesError = new Series("Error");
        Spline s;
        public Form1()
        {
            InitializeComponent();
            functions = new  Func<double, double>[5];
            functions[0] = x=>Math.Cos(x);
            functions[1] = x=>Math.Exp(x);
            functions[2] =  x =>Math.Sinh(x);
            functions[3] =  x=>Math.Sqrt(x);
            functions[4] = x=> x * x * x;
            buttons = new RadioButton[] { CosFunc, ExpFunc, SinHFunc, SqrtFunc, Plynom };
            seriesReal.Color = System.Drawing.Color.Red;
            seriesReal.ChartType = SeriesChartType.Line;


            seriesNeed.ChartType = SeriesChartType.Line;
            seriesNeed.Color = System.Drawing.Color.Green;

            seriesError.ChartType = SeriesChartType.Line;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var i = from b in buttons where  b.Checked select b.TabIndex;
            if (i.Count() == 0 || i.Count()>1)
                MessageBox.Show("Error");
            else
            {
                int index = i.First();
                double Anumber = Double.Parse(A.Text);
                double BNumber = Double.Parse(B.Text);
                double x0 = Double.Parse(X0.Text);
                double xn = Double.Parse(XN.Text);
                int N = (int)(this.Nodes.Value);
                s = Spline.GetSpline(x0, xn, N,  functions[index], Anumber, BNumber);
                Tuple<List<double>, List<double>> RealCoefs = s.GetNeedCoordinates(); //реальные точти
                Tuple<List<double>, List<double>> GotCoefs = s.GetRealCoordinates(); // from spline
                Tuple<List<double>, List<double>> Errors = s.GetError(RealCoefs.Item2, GotCoefs.Item2, RealCoefs.Item1);
                //throw new Exception();

                seriesReal.Points.Clear();
                seriesNeed.Points.Clear();
                seriesError.Points.Clear();
                
                for (int j=0; j<Errors.Item1.Count; ++j)
                {
                    seriesReal.Points.AddXY(GotCoefs.Item1.ElementAt(j), GotCoefs.Item2.ElementAt(j));
                    seriesNeed.Points.AddXY(RealCoefs.Item1.ElementAt(j), RealCoefs.Item2.ElementAt(j));
                    seriesError.Points.AddXY(Errors.Item1.ElementAt(j), Errors.Item2.ElementAt(j));
                }

                SplineChart.Series.Clear();
                chart1.Series.Clear();                
                SplineChart.Series.Add(seriesReal);
                SplineChart.Series.Add(seriesNeed);
                chart1.Series.Add(seriesError);
                
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new Koefficents(s)).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new MatrixForm(s._m)).Show();
        }
    }
}
