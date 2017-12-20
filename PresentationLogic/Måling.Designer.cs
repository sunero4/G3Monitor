using System.Drawing;

namespace PresentationLogic
{
    partial class Måling
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
            this.btn_Nulpunktsjustering = new System.Windows.Forms.Button();
            this.btn_Indstillinger = new System.Windows.Forms.Button();
            this.btn_StartMåling = new System.Windows.Forms.Button();
            this.btn_StopMåling = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label_Puls = new System.Windows.Forms.Label();
            this.label_SysDia = new System.Windows.Forms.Label();
            this.label_MiddelBT = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_patientNavn = new System.Windows.Forms.TextBox();
            this.txt_patientCPR = new System.Windows.Forms.TextBox();
            this.btn_filtrerMåling = new System.Windows.Forms.Button();
            this.btn_UfiltrerMåling = new System.Windows.Forms.Button();
            this.txtKommentar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_DeaktiverAlarm = new System.Windows.Forms.Button();
            this.btn_AktiverAlarm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Nulpunktsjustering
            // 
            this.btn_Nulpunktsjustering.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Nulpunktsjustering.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nulpunktsjustering.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Nulpunktsjustering.Location = new System.Drawing.Point(38, 32);
            this.btn_Nulpunktsjustering.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_Nulpunktsjustering.Name = "btn_Nulpunktsjustering";
            this.btn_Nulpunktsjustering.Size = new System.Drawing.Size(215, 72);
            this.btn_Nulpunktsjustering.TabIndex = 0;
            this.btn_Nulpunktsjustering.Text = "Nulpunktsjustering ";
            this.btn_Nulpunktsjustering.UseVisualStyleBackColor = false;
            this.btn_Nulpunktsjustering.Click += new System.EventHandler(this.btn_Nulpunktsjustering_Click);
            // 
            // btn_Indstillinger
            // 
            this.btn_Indstillinger.Enabled = false;
            this.btn_Indstillinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Indstillinger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Indstillinger.Location = new System.Drawing.Point(38, 112);
            this.btn_Indstillinger.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_Indstillinger.Name = "btn_Indstillinger";
            this.btn_Indstillinger.Size = new System.Drawing.Size(215, 69);
            this.btn_Indstillinger.TabIndex = 1;
            this.btn_Indstillinger.Text = "Indstillinger for måling";
            this.btn_Indstillinger.UseVisualStyleBackColor = true;
            this.btn_Indstillinger.Click += new System.EventHandler(this.btn_Indstillinger_Click);
            // 
            // btn_StartMåling
            // 
            this.btn_StartMåling.Enabled = false;
            this.btn_StartMåling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartMåling.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_StartMåling.Location = new System.Drawing.Point(38, 190);
            this.btn_StartMåling.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_StartMåling.Name = "btn_StartMåling";
            this.btn_StartMåling.Size = new System.Drawing.Size(215, 66);
            this.btn_StartMåling.TabIndex = 2;
            this.btn_StartMåling.Text = "Start måling";
            this.btn_StartMåling.UseVisualStyleBackColor = true;
            this.btn_StartMåling.Click += new System.EventHandler(this.btn_StartMåling_Click_1);
            // 
            // btn_StopMåling
            // 
            this.btn_StopMåling.Enabled = false;
            this.btn_StopMåling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StopMåling.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_StopMåling.Location = new System.Drawing.Point(38, 267);
            this.btn_StopMåling.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_StopMåling.Name = "btn_StopMåling";
            this.btn_StopMåling.Size = new System.Drawing.Size(215, 66);
            this.btn_StopMåling.TabIndex = 3;
            this.btn_StopMåling.Text = "Stop måling";
            this.btn_StopMåling.UseVisualStyleBackColor = true;
            this.btn_StopMåling.Click += new System.EventHandler(this.btn_StopMåling_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.Title = "Tid (sekunder)";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.Title = "Tryk (mmHg)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.Red;
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.Black;
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(332, 43);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.chart1.Name = "chart1";
            series1.BackImageTransparentColor = System.Drawing.Color.White;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Red;
            series1.LabelForeColor = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Blodtryk";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1155, 963);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1552, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Puls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1552, 362);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sys/Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(1552, 419);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Middel BT";
            // 
            // label_Puls
            // 
            this.label_Puls.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Puls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label_Puls.Location = new System.Drawing.Point(1668, 237);
            this.label_Puls.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Puls.MaximumSize = new System.Drawing.Size(150, 52);
            this.label_Puls.Name = "label_Puls";
            this.label_Puls.Size = new System.Drawing.Size(150, 52);
            this.label_Puls.TabIndex = 24;
            this.label_Puls.Text = "00";
            // 
            // label_SysDia
            // 
            this.label_SysDia.AutoSize = true;
            this.label_SysDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SysDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_SysDia.Location = new System.Drawing.Point(1673, 339);
            this.label_SysDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SysDia.MaximumSize = new System.Drawing.Size(250, 52);
            this.label_SysDia.Name = "label_SysDia";
            this.label_SysDia.Size = new System.Drawing.Size(51, 52);
            this.label_SysDia.TabIndex = 25;
            this.label_SysDia.Text = "0";
            // 
            // label_MiddelBT
            // 
            this.label_MiddelBT.AutoSize = true;
            this.label_MiddelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MiddelBT.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_MiddelBT.Location = new System.Drawing.Point(1673, 398);
            this.label_MiddelBT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_MiddelBT.MaximumSize = new System.Drawing.Size(150, 52);
            this.label_MiddelBT.Name = "label_MiddelBT";
            this.label_MiddelBT.Size = new System.Drawing.Size(56, 52);
            this.label_MiddelBT.TabIndex = 26;
            this.label_MiddelBT.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1544, 81);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(218, 29);
            this.label12.TabIndex = 27;
            this.label12.Text = "Patientoplysninger:";
            // 
            // txt_patientNavn
            // 
            this.txt_patientNavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patientNavn.Location = new System.Drawing.Point(1550, 113);
            this.txt_patientNavn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_patientNavn.Name = "txt_patientNavn";
            this.txt_patientNavn.Size = new System.Drawing.Size(300, 30);
            this.txt_patientNavn.TabIndex = 28;
            // 
            // txt_patientCPR
            // 
            this.txt_patientCPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patientCPR.Location = new System.Drawing.Point(1550, 148);
            this.txt_patientCPR.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_patientCPR.Name = "txt_patientCPR";
            this.txt_patientCPR.Size = new System.Drawing.Size(300, 30);
            this.txt_patientCPR.TabIndex = 29;
            // 
            // btn_filtrerMåling
            // 
            this.btn_filtrerMåling.Enabled = false;
            this.btn_filtrerMåling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtrerMåling.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_filtrerMåling.Location = new System.Drawing.Point(1530, 583);
            this.btn_filtrerMåling.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_filtrerMåling.Name = "btn_filtrerMåling";
            this.btn_filtrerMåling.Size = new System.Drawing.Size(163, 68);
            this.btn_filtrerMåling.TabIndex = 30;
            this.btn_filtrerMåling.Text = "Filtrer måling";
            this.btn_filtrerMåling.UseVisualStyleBackColor = true;
            this.btn_filtrerMåling.Click += new System.EventHandler(this.btn_filtrerMåling_Click);
            // 
            // btn_UfiltrerMåling
            // 
            this.btn_UfiltrerMåling.Enabled = false;
            this.btn_UfiltrerMåling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UfiltrerMåling.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_UfiltrerMåling.Location = new System.Drawing.Point(1530, 661);
            this.btn_UfiltrerMåling.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_UfiltrerMåling.Name = "btn_UfiltrerMåling";
            this.btn_UfiltrerMåling.Size = new System.Drawing.Size(163, 72);
            this.btn_UfiltrerMåling.TabIndex = 31;
            this.btn_UfiltrerMåling.Text = "Ufiltrer måling";
            this.btn_UfiltrerMåling.UseVisualStyleBackColor = true;
            this.btn_UfiltrerMåling.Click += new System.EventHandler(this.btn_UfiltrerMåling_Click);
            // 
            // txtKommentar
            // 
            this.txtKommentar.Location = new System.Drawing.Point(1708, 583);
            this.txtKommentar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtKommentar.Multiline = true;
            this.txtKommentar.Name = "txtKommentar";
            this.txtKommentar.Size = new System.Drawing.Size(179, 202);
            this.txtKommentar.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1690, 547);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "Kommentar til målingen:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1774, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 42);
            this.button1.TabIndex = 34;
            this.button1.Text = "Log ud ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_DeaktiverAlarm);
            this.groupBox1.Controls.Add(this.btn_AktiverAlarm);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(38, 547);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(263, 410);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alarm";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.Location = new System.Drawing.Point(134, 173);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(77, 28);
            this.numericUpDown4.TabIndex = 20;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(10, 172);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(76, 28);
            this.numericUpDown3.TabIndex = 19;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(134, 112);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(77, 28);
            this.numericUpDown2.TabIndex = 18;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(10, 111);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 28);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Minimum sys";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.MaximumSize = new System.Drawing.Size(250, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ændring af grænseværdier for alam aktivering:";
            // 
            // btn_DeaktiverAlarm
            // 
            this.btn_DeaktiverAlarm.Enabled = false;
            this.btn_DeaktiverAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeaktiverAlarm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DeaktiverAlarm.Location = new System.Drawing.Point(12, 220);
            this.btn_DeaktiverAlarm.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_DeaktiverAlarm.Name = "btn_DeaktiverAlarm";
            this.btn_DeaktiverAlarm.Size = new System.Drawing.Size(195, 72);
            this.btn_DeaktiverAlarm.TabIndex = 4;
            this.btn_DeaktiverAlarm.Text = "Deaktiver alarm";
            this.btn_DeaktiverAlarm.UseVisualStyleBackColor = true;
            this.btn_DeaktiverAlarm.Click += new System.EventHandler(this.btn_DeaktiverAlarm_Click_1);
            // 
            // btn_AktiverAlarm
            // 
            this.btn_AktiverAlarm.Enabled = false;
            this.btn_AktiverAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AktiverAlarm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AktiverAlarm.Location = new System.Drawing.Point(14, 308);
            this.btn_AktiverAlarm.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_AktiverAlarm.Name = "btn_AktiverAlarm";
            this.btn_AktiverAlarm.Size = new System.Drawing.Size(193, 74);
            this.btn_AktiverAlarm.TabIndex = 5;
            this.btn_AktiverAlarm.Text = "Aktiver alarm";
            this.btn_AktiverAlarm.UseVisualStyleBackColor = true;
            this.btn_AktiverAlarm.Click += new System.EventHandler(this.btn_AktiverAlarm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Maksimum sys";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Minimum dia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(130, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Maksimum dia";
            // 
            // Måling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1861, 1055);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtKommentar);
            this.Controls.Add(this.btn_UfiltrerMåling);
            this.Controls.Add(this.btn_filtrerMåling);
            this.Controls.Add(this.txt_patientCPR);
            this.Controls.Add(this.txt_patientNavn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_MiddelBT);
            this.Controls.Add(this.label_SysDia);
            this.Controls.Add(this.label_Puls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_StopMåling);
            this.Controls.Add(this.btn_StartMåling);
            this.Controls.Add(this.btn_Indstillinger);
            this.Controls.Add(this.btn_Nulpunktsjustering);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Måling";
            this.Text = "G3-Monitor: Måling";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Måling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Nulpunktsjustering;
        private System.Windows.Forms.Button btn_Indstillinger;
        private System.Windows.Forms.Button btn_StartMåling;
        private System.Windows.Forms.Button btn_StopMåling;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_Puls;
        private System.Windows.Forms.Label label_SysDia;
        private System.Windows.Forms.Label label_MiddelBT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_patientNavn;
        private System.Windows.Forms.TextBox txt_patientCPR;
        private System.Windows.Forms.Button btn_filtrerMåling;
        private System.Windows.Forms.Button btn_UfiltrerMåling;
        private System.Windows.Forms.TextBox txtKommentar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_DeaktiverAlarm;
        private System.Windows.Forms.Button btn_AktiverAlarm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}