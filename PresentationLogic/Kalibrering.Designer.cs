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
            this.groupBox1.Location = new System.Drawing.Point(24, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(928, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mindst 3 trykmålinger skal foretages";
            // 
            // btnNyMåling
            // 
            this.btnNyMåling.Location = new System.Drawing.Point(18, 23);
            this.btnNyMåling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNyMåling.Name = "btnNyMåling";
            this.btnNyMåling.Size = new System.Drawing.Size(114, 28);
            this.btnNyMåling.TabIndex = 7;
            this.btnNyMåling.Text = "Ny måling";
            this.btnNyMåling.UseVisualStyleBackColor = true;
            this.btnNyMåling.Click += new System.EventHandler(this.btnNyMåling_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(718, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "mmHg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "mmHg";
            // 
            // btnKalibrerMål
            // 
            this.btnKalibrerMål.Location = new System.Drawing.Point(328, 55);
            this.btnKalibrerMål.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKalibrerMål.Name = "btnKalibrerMål";
            this.btnKalibrerMål.Size = new System.Drawing.Size(158, 44);
            this.btnKalibrerMål.TabIndex = 4;
            this.btnKalibrerMål.Text = "Kalibrer måleudstyr";
            this.btnKalibrerMål.UseVisualStyleBackColor = true;
            this.btnKalibrerMål.Click += new System.EventHandler(this.btnKalibrerMål_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Målt tryk";
            // 
            // txtMåltTryk
            // 
            this.txtMåltTryk.Enabled = false;
            this.txtMåltTryk.Location = new System.Drawing.Point(630, 68);
            this.txtMåltTryk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMåltTryk.Name = "txtMåltTryk";
            this.txtMåltTryk.ReadOnly = true;
            this.txtMåltTryk.Size = new System.Drawing.Size(86, 22);
            this.txtMåltTryk.TabIndex = 2;
            // 
            // txtIndtastTryk
            // 
            this.txtIndtastTryk.Location = new System.Drawing.Point(106, 69);
            this.txtIndtastTryk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIndtastTryk.Name = "txtIndtastTryk";
            this.txtIndtastTryk.Size = new System.Drawing.Size(108, 22);
            this.txtIndtastTryk.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
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
            this.chartMåltTryk.Location = new System.Drawing.Point(294, 166);
            this.chartMåltTryk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.chartMåltTryk.Size = new System.Drawing.Size(448, 365);
            this.chartMåltTryk.TabIndex = 1;
            this.chartMåltTryk.Text = "chart1";
            // 
            // ListBoxMåltTryk
            // 
            this.ListBoxMåltTryk.FormattingEnabled = true;
            this.ListBoxMåltTryk.ItemHeight = 16;
            this.ListBoxMåltTryk.Location = new System.Drawing.Point(26, 166);
            this.ListBoxMåltTryk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListBoxMåltTryk.Name = "ListBoxMåltTryk";
            this.ListBoxMåltTryk.Size = new System.Drawing.Size(250, 292);
            this.ListBoxMåltTryk.TabIndex = 2;
            // 
            // btnAfslutKali
            // 
            this.btnAfslutKali.Location = new System.Drawing.Point(802, 486);
            this.btnAfslutKali.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAfslutKali.Name = "btnAfslutKali";
            this.btnAfslutKali.Size = new System.Drawing.Size(150, 45);
            this.btnAfslutKali.TabIndex = 3;
            this.btnAfslutKali.Text = "Afslut kalibrering";
            this.btnAfslutKali.UseVisualStyleBackColor = true;
            this.btnAfslutKali.Click += new System.EventHandler(this.btnAfslutKali_Click);
            // 
            // btnSletMåling
            // 
            this.btnSletMåling.Location = new System.Drawing.Point(26, 467);
            this.btnSletMåling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSletMåling.Name = "btnSletMåling";
            this.btnSletMåling.Size = new System.Drawing.Size(130, 39);
            this.btnSletMåling.TabIndex = 6;
            this.btnSletMåling.Text = "Slet måltpunkt";
            this.btnSletMåling.UseVisualStyleBackColor = true;
            this.btnSletMåling.Click += new System.EventHandler(this.btnSletMåling_Click);
            // 
            // ScrollBarHældning
            // 
            this.ScrollBarHældning.Location = new System.Drawing.Point(826, 186);
            this.ScrollBarHældning.Name = "ScrollBarHældning";
            this.ScrollBarHældning.Size = new System.Drawing.Size(34, 25);
            this.ScrollBarHældning.TabIndex = 15;
            this.ScrollBarHældning.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarHældning_Scroll);
            // 
            // txtHældningskoefficient
            // 
            this.txtHældningskoefficient.Location = new System.Drawing.Point(754, 186);
            this.txtHældningskoefficient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHældningskoefficient.Name = "txtHældningskoefficient";
            this.txtHældningskoefficient.Size = new System.Drawing.Size(66, 22);
            this.txtHældningskoefficient.TabIndex = 14;
            this.txtHældningskoefficient.TextChanged += new System.EventHandler(this.txtHældningskoefficient_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Juster hældningskoefficienten";
            // 
            // Kalibrering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 539);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ScrollBarHældning);
            this.Controls.Add(this.txtHældningskoefficient);
            this.Controls.Add(this.btnSletMåling);
            this.Controls.Add(this.btnAfslutKali);
            this.Controls.Add(this.ListBoxMåltTryk);
            this.Controls.Add(this.chartMåltTryk);
            this.Controls.Add(this.groupBox1);
            this.Enabled = false;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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