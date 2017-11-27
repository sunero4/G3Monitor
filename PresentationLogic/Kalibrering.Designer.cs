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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.ScrollBarHældning = new System.Windows.Forms.VScrollBar();
            this.txtHældningskoefficient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMåltTryk)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(48, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(1856, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mindst 3 trykmålinger skal foretages";
            // 
            // btnNyMåling
            // 
            this.btnNyMåling.Location = new System.Drawing.Point(35, 45);
            this.btnNyMåling.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNyMåling.Name = "btnNyMåling";
            this.btnNyMåling.Size = new System.Drawing.Size(229, 55);
            this.btnNyMåling.TabIndex = 7;
            this.btnNyMåling.Text = "Ny måling";
            this.btnNyMåling.UseVisualStyleBackColor = true;
            this.btnNyMåling.Click += new System.EventHandler(this.btnNyMåling_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1437, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "mmHg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "mmHg";
            // 
            // btnKalibrerMål
            // 
            this.btnKalibrerMål.Location = new System.Drawing.Point(656, 107);
            this.btnKalibrerMål.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnKalibrerMål.Name = "btnKalibrerMål";
            this.btnKalibrerMål.Size = new System.Drawing.Size(315, 86);
            this.btnKalibrerMål.TabIndex = 4;
            this.btnKalibrerMål.Text = "Kalibrer måleudstyr";
            this.btnKalibrerMål.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1085, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Målt tryk";
            // 
            // txtMåltTryk
            // 
            this.txtMåltTryk.Enabled = false;
            this.txtMåltTryk.Location = new System.Drawing.Point(1261, 131);
            this.txtMåltTryk.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtMåltTryk.Name = "txtMåltTryk";
            this.txtMåltTryk.ReadOnly = true;
            this.txtMåltTryk.Size = new System.Drawing.Size(169, 38);
            this.txtMåltTryk.TabIndex = 2;
            // 
            // txtIndtastTryk
            // 
            this.txtIndtastTryk.Location = new System.Drawing.Point(213, 134);
            this.txtIndtastTryk.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtIndtastTryk.Name = "txtIndtastTryk";
            this.txtIndtastTryk.Size = new System.Drawing.Size(212, 38);
            this.txtIndtastTryk.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indtast tryk";
            // 
            // chartMåltTryk
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMåltTryk.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chartMåltTryk.Legends.Add(legend1);
            this.chartMåltTryk.Location = new System.Drawing.Point(589, 322);
            this.chartMåltTryk.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chartMåltTryk.Name = "chartMåltTryk";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Indtastet tryk";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Målte tryk";
            this.chartMåltTryk.Series.Add(series1);
            this.chartMåltTryk.Series.Add(series2);
            this.chartMåltTryk.Size = new System.Drawing.Size(896, 708);
            this.chartMåltTryk.TabIndex = 1;
            this.chartMåltTryk.Text = "chart1";
            this.chartMåltTryk.Click += new System.EventHandler(this.chartMåltTryk_Click);
            // 
            // ListBoxMåltTryk
            // 
            this.ListBoxMåltTryk.FormattingEnabled = true;
            this.ListBoxMåltTryk.ItemHeight = 31;
            this.ListBoxMåltTryk.Location = new System.Drawing.Point(51, 322);
            this.ListBoxMåltTryk.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ListBoxMåltTryk.Name = "ListBoxMåltTryk";
            this.ListBoxMåltTryk.Size = new System.Drawing.Size(497, 562);
            this.ListBoxMåltTryk.TabIndex = 2;
            // 
            // btnAfslutKali
            // 
            this.btnAfslutKali.Location = new System.Drawing.Point(1603, 942);
            this.btnAfslutKali.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAfslutKali.Name = "btnAfslutKali";
            this.btnAfslutKali.Size = new System.Drawing.Size(301, 88);
            this.btnAfslutKali.TabIndex = 3;
            this.btnAfslutKali.Text = "Afslut kalibrering";
            this.btnAfslutKali.UseVisualStyleBackColor = true;
            this.btnAfslutKali.Click += new System.EventHandler(this.btnAfslutKali_Click);
            // 
            // btnSletMåling
            // 
            this.btnSletMåling.Location = new System.Drawing.Point(51, 904);
            this.btnSletMåling.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSletMåling.Name = "btnSletMåling";
            this.btnSletMåling.Size = new System.Drawing.Size(261, 76);
            this.btnSletMåling.TabIndex = 6;
            this.btnSletMåling.Text = "Slet måltpunkt";
            this.btnSletMåling.UseVisualStyleBackColor = true;
            this.btnSletMåling.Click += new System.EventHandler(this.btnSletMåling_Click);
            // 
            // ScrollBarHældning
            // 
            this.ScrollBarHældning.Location = new System.Drawing.Point(1653, 360);
            this.ScrollBarHældning.Name = "ScrollBarHældning";
            this.ScrollBarHældning.Size = new System.Drawing.Size(34, 48);
            this.ScrollBarHældning.TabIndex = 15;
            // 
            // txtHældningskoefficient
            // 
            this.txtHældningskoefficient.Location = new System.Drawing.Point(1509, 360);
            this.txtHældningskoefficient.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtHældningskoefficient.Name = "txtHældningskoefficient";
            this.txtHældningskoefficient.Size = new System.Drawing.Size(129, 38);
            this.txtHældningskoefficient.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1501, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Juster hældningskoefficienten";
            // 
            // Kalibrering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1939, 1083);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ScrollBarHældning);
            this.Controls.Add(this.txtHældningskoefficient);
            this.Controls.Add(this.btnSletMåling);
            this.Controls.Add(this.btnAfslutKali);
            this.Controls.Add(this.ListBoxMåltTryk);
            this.Controls.Add(this.chartMåltTryk);
            this.Controls.Add(this.groupBox1);
            this.Enabled = false;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Kalibrering";
            this.Text = "G3-monitor: Kalibrering";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMåltTryk)).EndInit();
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
        private System.Windows.Forms.VScrollBar ScrollBarHældning;
        private System.Windows.Forms.TextBox txtHældningskoefficient;
        private System.Windows.Forms.Label label3;
    }
}