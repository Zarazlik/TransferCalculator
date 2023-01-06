namespace TransferСalculation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lable_RuToTl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lable_TlToUsd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new WinFormsChart.Chart();
            this.chart2 = new WinFormsChart.Chart();
            this.chart3 = new WinFormsChart.Chart();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lable_RuToTl
            // 
            this.Lable_RuToTl.AutoSize = true;
            this.Lable_RuToTl.Location = new System.Drawing.Point(64, 47);
            this.Lable_RuToTl.Name = "Lable_RuToTl";
            this.Lable_RuToTl.Size = new System.Drawing.Size(16, 20);
            this.Lable_RuToTl.TabIndex = 3;
            this.Lable_RuToTl.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "RUB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "USD";
            // 
            // Lable_TlToUsd
            // 
            this.Lable_TlToUsd.AutoSize = true;
            this.Lable_TlToUsd.Location = new System.Drawing.Point(64, 110);
            this.Lable_TlToUsd.Name = "Lable_TlToUsd";
            this.Lable_TlToUsd.Size = new System.Drawing.Size(16, 20);
            this.Lable_TlToUsd.TabIndex = 7;
            this.Lable_TlToUsd.Text = "?";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update Exchange Rates";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Count_RUB);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(64, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 10;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Count_TL);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(64, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 11;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Count_USD);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.Lable_RuToTl);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Lable_TlToUsd);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 554);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // chart1
            // 
            this.chart1.chartStile = WinFormsChart.Chart.ChartStile.Line;
            this.chart1.GreadVolumeStap = 0.5F;
            this.chart1.Location = new System.Drawing.Point(217, 12);
            this.chart1.MaxValue = 10;
            this.chart1.MinValue = 0;
            this.chart1.Name = "chart1";
            this.chart1.NumberOfPoles = ((short)(90));
            this.chart1.Size = new System.Drawing.Size(1068, 200);
            this.chart1.TabIndex = 20;
            // 
            // chart2
            // 
            this.chart2.chartStile = WinFormsChart.Chart.ChartStile.Line;
            this.chart2.GreadVolumeStap = 5F;
            this.chart2.Location = new System.Drawing.Point(217, 218);
            this.chart2.MaxValue = 50;
            this.chart2.MinValue = 0;
            this.chart2.Name = "chart2";
            this.chart2.NumberOfPoles = ((short)(90));
            this.chart2.Size = new System.Drawing.Size(1068, 200);
            this.chart2.TabIndex = 19;
            // 
            // chart3
            // 
            this.chart3.chartStile = WinFormsChart.Chart.ChartStile.Line;
            this.chart3.GreadVolumeStap = 5F;
            this.chart3.Location = new System.Drawing.Point(217, 424);
            this.chart3.MaxValue = 100;
            this.chart3.MinValue = 0;
            this.chart3.Name = "chart3";
            this.chart3.NumberOfPoles = ((short)(90));
            this.chart3.Size = new System.Drawing.Size(1068, 200);
            this.chart3.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 636);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Transfer calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label Lable_RuToTl;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label Lable_TlToUsd;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Panel panel1;
        private Label label2;
        private WinFormsChart.Chart chart1;
        private WinFormsChart.Chart chart2;
        private WinFormsChart.Chart chart3;
    }
}