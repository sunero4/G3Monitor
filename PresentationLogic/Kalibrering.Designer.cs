namespace PresentationLogic
{
    partial class Kalibrering
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNyMåling = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKalibrerMål = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMåltTryk = new System.Windows.Forms.TextBox();
            this.txtIndtastTryk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartMåltTryk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ListBoxMåltTryk = new System.Windows.Forms.ListBox();
            this.btnAfslutKali = new System.Windows.Forms.Button();
            this.btnSletMåling = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMåltTryk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNyMåling);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnKalibrerMål);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMåltTryk);
            this.groupBox1.Controls.Add(this.txtIndtastTryk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(1856, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foretag mindst 3 trykmålinger ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnNyMåling
            // 
            this.btnNyMåling.Location = new System.Drawing.Point(50, 83);
            this.btnNyMåling.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNyMåling.Name = "btnNyMåling";
            this.btnNyMåling.Size = new System.Drawing.Size(231, 70);
            this.btnNyMåling.TabIndex = 7;
            this.btnNyMåling.Text = "Ny måling";
            this.btnNyMåling.UseVisualStyleBackColor = true;
            this.btnNyMåling.Click += new System.EventHandler(this.btnNyMåling_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1640, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Volt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "mmHg";
            // 
            // btnKalibrerMål
            // 
            this.btnKalibrerMål.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKalibrerMål.Location = new System.Drawing.Point(744, 173);
            this.btnKalibrerMål.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnKalibrerMål.Name = "btnKalibrerMål";
            this.btnKalibrerMål.Size = new System.Drawing.Size(315, 108);
            this.btnKalibrerMål.TabIndex = 4;
            this.btnKalibrerMål.Text = "Kalibrer måleudstyr";
            this.btnKalibrerMål.UseVisualStyleBackColor = true;
            this.btnKalibrerMål.Click += new System.EventHandler(this.btnKalibrerMål_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1169, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Målt spænding";
            // 
            // txtMåltTryk
            // 
            this.txtMåltTryk.Enabled = false;
            this.txtMåltTryk.Location = new System.Drawing.Point(1455, 205);
            this.txtMåltTryk.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtMåltTryk.Name = "txtMåltTryk";
            this.txtMåltTryk.ReadOnly = true;
            this.txtMåltTryk.Size = new System.Drawing.Size(169, 30);
            this.txtMåltTryk.TabIndex = 2;
            // 
            // txtIndtastTryk
            // 
            this.txtIndtastTryk.Location = new System.Drawing.Point(264, 206);
            this.txtIndtastTryk.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtIndtastTryk.Name = "txtIndtastTryk";
            this.txtIndtastTryk.Size = new System.Drawing.Size(212, 30);
            this.txtIndtastTryk.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indtast tryk";
            // 
            // chartMåltTryk
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMåltTryk.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chartMåltTryk.Legends.Add(legend2);
            this.chartMåltTryk.Location = new System.Drawing.Point(412, 536);
            this.chartMåltTryk.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chartMåltTryk.Name = "chartMåltTryk";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Målt spænding ";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chartMåltTryk.Series.Add(series3);
            this.chartMåltTryk.Series.Add(series4);
            this.chartMåltTryk.Size = new System.Drawing.Size(1077, 708);
            this.chartMåltTryk.TabIndex = 1;
            this.chartMåltTryk.Text = "chart1";
            // 
            // ListBoxMåltTryk
            // 
            this.ListBoxMåltTryk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxMåltTryk.FormattingEnabled = true;
            this.ListBoxMåltTryk.ItemHeight = 25;
            this.ListBoxMåltTryk.Location = new System.Drawing.Point(55, 536);
            this.ListBoxMåltTryk.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ListBoxMåltTryk.Name = "ListBoxMåltTryk";
            this.ListBoxMåltTryk.Size = new System.Drawing.Size(320, 554);
            this.ListBoxMåltTryk.TabIndex = 2;
            // 
            // btnAfslutKali
            // 
            this.btnAfslutKali.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfslutKali.Location = new System.Drawing.Point(1513, 1118);
            this.btnAfslutKali.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAfslutKali.Name = "btnAfslutKali";
            this.btnAfslutKali.Size = new System.Drawing.Size(351, 126);
            this.btnAfslutKali.TabIndex = 3;
            this.btnAfslutKali.Text = "Afslut og gem kalibrering";
            this.btnAfslutKali.UseVisualStyleBackColor = true;
            this.btnAfslutKali.Click += new System.EventHandler(this.btnAfslutKali_Click);
            // 
            // btnSletMåling
            // 
            this.btnSletMåling.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSletMåling.Location = new System.Drawing.Point(55, 1118);
            this.btnSletMåling.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSletMåling.Name = "btnSletMåling";
            this.btnSletMåling.Size = new System.Drawing.Size(320, 126);
            this.btnSletMåling.TabIndex = 6;
            this.btnSletMåling.Text = "Slet måltpunkt";
            this.btnSletMåling.UseVisualStyleBackColor = true;
            this.btnSletMåling.Click += new System.EventHandler(this.btnSletMåling_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1505, 536);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 48);
            this.label3.TabIndex = 16;
            this.label3.Text = "Juster \r\nhældningskoefficienten:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(1513, 647);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(131, 34);
            this.numericUpDown1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1946, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 75);
            this.button1.TabIndex = 18;
            this.button1.Text = "Log ud";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kalibrering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSletMåling);
            this.Controls.Add(this.btnAfslutKali);
            this.Controls.Add(this.ListBoxMåltTryk);
            this.Controls.Add(this.chartMåltTryk);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Kalibrering";
            this.Text = "G3-monitor: Kalibrering";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMåltTryk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMåltTryk;
        private System.Windows.Forms.TextBox txtIndtastTryk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKalibrerMål;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMåltTryk;
        private System.Windows.Forms.ListBox ListBoxMåltTryk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAfslutKali;
        private System.Windows.Forms.Button btnNyMåling;
        private System.Windows.Forms.Button btnSletMåling;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
    }
}