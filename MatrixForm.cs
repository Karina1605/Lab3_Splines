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
    public partial class MatrixForm: Form
    {
        public MatrixForm(Matrix matrix)
        {
            InitializeComponent();
            for (int i=1; i<=matrix.result.Dimension; ++i)
            {
                DataGridViewColumn column = new DataGridViewColumn();
                column.HeaderText = column.Name = i.ToString();
                column.CellTemplate = new DataGridViewTextBoxCell();
                dataGridView1.Columns.Add(column);
            }
            DataGridViewColumn res = new DataGridViewColumn();
            res.HeaderText = res.Name = "Res";
            res.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(res);
            for (int i = 1; i<=matrix.result.Dimension; ++i)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = i.ToString();
                for (int j=1; j<=matrix.result.Dimension; ++j)
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    cell.Value = matrix[i, j];
                    row.Cells.Add(cell);
                }
                DataGridViewTextBoxCell resCell = new DataGridViewTextBoxCell();
                resCell.Value = matrix.result[i];
                resCell.Style = new DataGridViewCellStyle();
                resCell.Style.BackColor = Color.AliceBlue;
                row.Cells.Add(resCell);
                dataGridView1.Rows.Add(row);
            }
        }

        private void MatrixForm_Load(object sender, EventArgs e)
        {

        }
    }
}
