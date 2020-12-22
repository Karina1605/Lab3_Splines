
namespace Lab3_Splines
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SplineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Nodes = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.PanelFunc = new System.Windows.Forms.Panel();
            this.Plynom = new System.Windows.Forms.RadioButton();
            this.CosFunc = new System.Windows.Forms.RadioButton();
            this.ExpFunc = new System.Windows.Forms.RadioButton();
            this.SinHFunc = new System.Windows.Forms.RadioButton();
            this.SqrtFunc = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.XN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.X0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SplineChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nodes)).BeginInit();
            this.PanelFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // SplineChart
            // 
            chartArea1.Name = "ChartArea1";
            this.SplineChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SplineChart.Legends.Add(legend1);
            this.SplineChart.Location = new System.Drawing.Point(372, 33);
            this.SplineChart.Name = "SplineChart";
            this.SplineChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.SplineChart.Series.Add(series1);
            this.SplineChart.Size = new System.Drawing.Size(911, 389);
            this.SplineChart.TabIndex = 0;
            this.SplineChart.Text = "SplineChart";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Nodes);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.PanelFunc);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.B);
            this.groupBox1.Controls.Add(this.A);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.XN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.X0);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 634);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 37);
            this.button2.TabIndex = 18;
            this.button2.Text = "Посмотреть коэффиценты";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Nodes
            // 
            this.Nodes.Location = new System.Drawing.Point(42, 390);
            this.Nodes.Name = "Nodes";
            this.Nodes.Size = new System.Drawing.Size(120, 22);
            this.Nodes.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "N";
            // 
            // PanelFunc
            // 
            this.PanelFunc.Controls.Add(this.Plynom);
            this.PanelFunc.Controls.Add(this.CosFunc);
            this.PanelFunc.Controls.Add(this.ExpFunc);
            this.PanelFunc.Controls.Add(this.SinHFunc);
            this.PanelFunc.Controls.Add(this.SqrtFunc);
            this.PanelFunc.Location = new System.Drawing.Point(13, 51);
            this.PanelFunc.Name = "PanelFunc";
            this.PanelFunc.Size = new System.Drawing.Size(200, 131);
            this.PanelFunc.TabIndex = 15;
            // 
            // Plynom
            // 
            this.Plynom.AutoSize = true;
            this.Plynom.Location = new System.Drawing.Point(4, 107);
            this.Plynom.Name = "Plynom";
            this.Plynom.Size = new System.Drawing.Size(134, 21);
            this.Plynom.TabIndex = 4;
            this.Plynom.TabStop = true;
            this.Plynom.Text = "x^3 - 2x^2 +6x+1";
            this.Plynom.UseVisualStyleBackColor = true;
            // 
            // CosFunc
            // 
            this.CosFunc.AutoSize = true;
            this.CosFunc.Location = new System.Drawing.Point(3, 3);
            this.CosFunc.Name = "CosFunc";
            this.CosFunc.Size = new System.Drawing.Size(69, 21);
            this.CosFunc.TabIndex = 0;
            this.CosFunc.TabStop = true;
            this.CosFunc.Text = "Cos(x)";
            this.CosFunc.UseVisualStyleBackColor = true;
            // 
            // ExpFunc
            // 
            this.ExpFunc.AutoSize = true;
            this.ExpFunc.Location = new System.Drawing.Point(3, 30);
            this.ExpFunc.Name = "ExpFunc";
            this.ExpFunc.Size = new System.Drawing.Size(68, 21);
            this.ExpFunc.TabIndex = 1;
            this.ExpFunc.TabStop = true;
            this.ExpFunc.Text = "Exp(x)";
            this.ExpFunc.UseVisualStyleBackColor = true;
            // 
            // SinHFunc
            // 
            this.SinHFunc.AutoSize = true;
            this.SinHFunc.Location = new System.Drawing.Point(3, 57);
            this.SinHFunc.Name = "SinHFunc";
            this.SinHFunc.Size = new System.Drawing.Size(75, 21);
            this.SinHFunc.TabIndex = 2;
            this.SinHFunc.TabStop = true;
            this.SinHFunc.Text = "SinH(x)";
            this.SinHFunc.UseVisualStyleBackColor = true;
            // 
            // SqrtFunc
            // 
            this.SqrtFunc.AutoSize = true;
            this.SqrtFunc.Location = new System.Drawing.Point(3, 84);
            this.SqrtFunc.Name = "SqrtFunc";
            this.SqrtFunc.Size = new System.Drawing.Size(71, 21);
            this.SqrtFunc.TabIndex = 3;
            this.SqrtFunc.TabStop = true;
            this.SqrtFunc.Text = "Sqrt(x)";
            this.SqrtFunc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(42, 341);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 22);
            this.B.TabIndex = 13;
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(42, 313);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 22);
            this.A.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Краевые условия";
            // 
            // XN
            // 
            this.XN.Location = new System.Drawing.Point(39, 257);
            this.XN.Name = "XN";
            this.XN.Size = new System.Drawing.Size(100, 22);
            this.XN.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "XN";
            // 
            // X0
            // 
            this.X0.Location = new System.Drawing.Point(39, 225);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(100, 22);
            this.X0.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "X0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Границы интервала";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Функция";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(372, 460);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(911, 436);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "ErrorChart";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Функции";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ошибка";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 560);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 36);
            this.button3.TabIndex = 19;
            this.button3.Text = "Посмотреть матрицу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 966);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SplineChart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SplineChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nodes)).EndInit();
            this.PanelFunc.ResumeLayout(false);
            this.PanelFunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SplineChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox XN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox X0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton SqrtFunc;
        private System.Windows.Forms.RadioButton SinHFunc;
        private System.Windows.Forms.RadioButton ExpFunc;
        private System.Windows.Forms.RadioButton CosFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel PanelFunc;
        private System.Windows.Forms.NumericUpDown Nodes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton Plynom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

