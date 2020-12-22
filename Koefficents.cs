using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Splines
{
    public partial class Koefficents : Form
    {
        public Koefficents(Spline spline)
        {
            InitializeComponent();
            //DataGridViewColumnCollection columnCollection = new DataGridViewColumnCollection(dataGridView1);
            DataGridViewColumn ak = new DataGridViewColumn();
            DataGridViewColumn bk = new DataGridViewColumn();
            DataGridViewColumn ck = new DataGridViewColumn();
            DataGridViewColumn dk = new DataGridViewColumn();

            ak.HeaderText = ak.Name = "a";
            bk.HeaderText = bk.Name = "b";
            ck.HeaderText = ck.Name = "c";
            dk.HeaderText = dk.Name = "d";
            ak.CellTemplate = new DataGridViewTextBoxCell();
            bk.CellTemplate = new DataGridViewTextBoxCell();
            ck.CellTemplate = new DataGridViewTextBoxCell();
            dk.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(ak);
            dataGridView1.Columns.Add(bk);
            dataGridView1.Columns.Add(ck);
            dataGridView1.Columns.Add(dk);
            for (int i=1; i<=spline._a.Dimension; ++i)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = i.ToString();
                DataGridViewCell a = new DataGridViewTextBoxCell();
                a.Value = spline._a[i];
                DataGridViewCell b = new DataGridViewTextBoxCell();
                b.Value = spline._b[i];
                DataGridViewCell c= new DataGridViewTextBoxCell();
                DataGridViewCell d = new DataGridViewTextBoxCell();
                c.Value = spline._c[i];
                d.Value = spline._d[i];
                row.Cells.AddRange(a, b, c, d);
                dataGridView1.Rows.Add(row);
            }
        }

        private void Koefficents_Load(object sender, EventArgs e)
        {

        }
    }
}
