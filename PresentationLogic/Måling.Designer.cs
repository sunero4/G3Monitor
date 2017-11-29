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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_Nulpunktsjustering = new System.Windows.Forms.Button();
            this.btn_Indstillinger = new System.Windows.Forms.Button();
            this.btn_StartMåling = new System.Windows.Forms.Button();
            this.btn_StopMåling = new System.Windows.Forms.Button();
            this.btn_DeaktiverAlarm = new System.Windows.Forms.Button();
            this.btn_AktiverAlarm = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericMinSys = new System.Windows.Forms.NumericUpDown();
            this.numericMaksSys = new System.Windows.Forms.NumericUpDown();
            this.numericMinDia = new System.Windows.Forms.NumericUpDown();
            this.numericMaksDia = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinSys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaksSys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaksDia)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Nulpunktsjustering
            // 
            this.btn_Nulpunktsjustering.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Nulpunktsjustering.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Nulpunktsjustering.Location = new System.Drawing.Point(76, 62);
            this.btn_Nulpunktsjustering.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_Nulpunktsjustering.Name = "btn_Nulpunktsjustering";
            this.btn_Nulpunktsjustering.Size = new System.Drawing.Size(284, 91);
            this.btn_Nulpunktsjustering.TabIndex = 0;
            this.btn_Nulpunktsjustering.Text = "Nulpunktsjustering ";
            this.btn_Nulpunktsjustering.UseVisualStyleBackColor = false;
            this.btn_Nulpunktsjustering.Click += new System.EventHandler(this.btn_Nulpunktsjustering_Click);
            // 
            // btn_Indstillinger
            // 
            this.btn_Indstillinger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Indstillinger.Location = new System.Drawing.Point(76, 184);
            this.btn_Indstillinger.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_Indstillinger.Name = "btn_Indstillinger";
            this.btn_Indstillinger.Size = new System.Drawing.Size(284, 87);
            this.btn_Indstillinger.TabIndex = 1;
            this.btn_Indstillinger.Text = "Indstillinger for måling";
            this.btn_Indstillinger.UseVisualStyleBackColor = true;
            // 
            // btn_StartMåling
            // 
            this.btn_StartMåling.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_StartMåling.Location = new System.Drawing.Point(76, 302);
            this.btn_StartMåling.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_StartMåling.Name = "btn_StartMåling";
            this.btn_StartMåling.Size = new System.Drawing.Size(284, 93);
            this.btn_StartMåling.TabIndex = 2;
            this.btn_StartMåling.Text = "Start måling";
            this.btn_StartMåling.UseVisualStyleBackColor = true;
            this.btn_StartMåling.Click += new System.EventHandler(this.btn_StartMåling_Click_1);
            // 
            // btn_StopMåling
            // 
            this.btn_StopMåling.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_StopMåling.Location = new System.Drawing.Point(76, 422);
            this.btn_StopMåling.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_StopMåling.Name = "btn_StopMåling";
            this.btn_StopMåling.Size = new System.Drawing.Size(284, 91);
            this.btn_StopMåling.TabIndex = 3;
            this.btn_StopMåling.Text = "Stop måling";
            this.btn_StopMåling.UseVisualStyleBackColor = true;
            // 
            // btn_DeaktiverAlarm
            // 
            this.btn_DeaktiverAlarm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DeaktiverAlarm.Location = new System.Drawing.Point(36, 422);
            this.btn_DeaktiverAlarm.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_DeaktiverAlarm.Name = "btn_DeaktiverAlarm";
            this.btn_DeaktiverAlarm.Size = new System.Drawing.Size(272, 85);
            this.btn_DeaktiverAlarm.TabIndex = 4;
            this.btn_DeaktiverAlarm.Text = "Deaktiver alarm";
            this.btn_DeaktiverAlarm.UseVisualStyleBackColor = true;
            this.btn_DeaktiverAlarm.Click += new System.EventHandler(this.btn_DeaktiverAlarm_Click_1);
            // 
            // btn_AktiverAlarm
            // 
            this.btn_AktiverAlarm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AktiverAlarm.Location = new System.Drawing.Point(36, 541);
            this.btn_AktiverAlarm.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_AktiverAlarm.Name = "btn_AktiverAlarm";
            this.btn_AktiverAlarm.Size = new System.Drawing.Size(272, 87);
            this.btn_AktiverAlarm.TabIndex = 5;
            this.btn_AktiverAlarm.Text = "Aktiver alarm";
            this.btn_AktiverAlarm.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Black;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.HeaderSeparatorColor = System.Drawing.Color.White;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            legend2.TitleForeColor = System.Drawing.Color.White;
            legend2.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(460, 184);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chart1.Name = "chart1";
            series2.BackImageTransparentColor = System.Drawing.Color.White;
            series2.BackSecondaryColor = System.Drawing.Color.White;
            series2.BorderColor = System.Drawing.Color.White;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.White;
            series2.LabelForeColor = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1484, 1110);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1940, 420);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Puls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1940, 610);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sys/Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(1940, 752);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Middel BT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(28, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.MaximumSize = new System.Drawing.Size(400, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 64);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ændring af grænseværdier for alam aktivering:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Minimum sys";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Maksimum sys";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 287);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Minimum dia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 287);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Maksimum dia";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.numericMaksDia);
            this.groupBox1.Controls.Add(this.numericMinDia);
            this.groupBox1.Controls.Add(this.numericMaksSys);
            this.groupBox1.Controls.Add(this.numericMinSys);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_DeaktiverAlarm);
            this.groupBox1.Controls.Add(this.btn_AktiverAlarm);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(36, 610);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(468, 663);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alarm";
            this.groupBox1.Visible = false;
            // 
            // label_Puls
            // 
            this.label_Puls.AutoSize = true;
            this.label_Puls.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Puls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label_Puls.Location = new System.Drawing.Point(2148, 372);
            this.label_Puls.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Puls.MaximumSize = new System.Drawing.Size(100, 101);
            this.label_Puls.Name = "label_Puls";
            this.label_Puls.Size = new System.Drawing.Size(83, 91);
            this.label_Puls.TabIndex = 24;
            this.label_Puls.Text = "0";
            // 
            // label_SysDia
            // 
            this.label_SysDia.AutoSize = true;
            this.label_SysDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SysDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_SysDia.Location = new System.Drawing.Point(2148, 564);
            this.label_SysDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SysDia.MaximumSize = new System.Drawing.Size(100, 101);
            this.label_SysDia.Name = "label_SysDia";
            this.label_SysDia.Size = new System.Drawing.Size(83, 91);
            this.label_SysDia.TabIndex = 25;
            this.label_SysDia.Text = "0";
            // 
            // label_MiddelBT
            // 
            this.label_MiddelBT.AutoSize = true;
            this.label_MiddelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MiddelBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label_MiddelBT.Location = new System.Drawing.Point(2148, 701);
            this.label_MiddelBT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MiddelBT.MaximumSize = new System.Drawing.Size(100, 101);
            this.label_MiddelBT.Name = "label_MiddelBT";
            this.label_MiddelBT.Size = new System.Drawing.Size(93, 91);
            this.label_MiddelBT.TabIndex = 26;
            this.label_MiddelBT.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1940, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(260, 32);
            this.label12.TabIndex = 27;
            this.label12.Text = "Patientoplysninger:";
            // 
            // txt_patientNavn
            // 
            this.txt_patientNavn.Location = new System.Drawing.Point(1944, 118);
            this.txt_patientNavn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_patientNavn.Name = "txt_patientNavn";
            this.txt_patientNavn.Size = new System.Drawing.Size(256, 38);
            this.txt_patientNavn.TabIndex = 28;
            // 
            // txt_patientCPR
            // 
            this.txt_patientCPR.Location = new System.Drawing.Point(1944, 184);
            this.txt_patientCPR.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_patientCPR.Name = "txt_patientCPR";
            this.txt_patientCPR.Size = new System.Drawing.Size(256, 38);
            this.txt_patientCPR.TabIndex = 29;
            // 
            // btn_filtrerMåling
            // 
            this.btn_filtrerMåling.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_filtrerMåling.Location = new System.Drawing.Point(1944, 978);
            this.btn_filtrerMåling.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_filtrerMåling.Name = "btn_filtrerMåling";
            this.btn_filtrerMåling.Size = new System.Drawing.Size(252, 103);
            this.btn_filtrerMåling.TabIndex = 30;
            this.btn_filtrerMåling.Text = "Filtrer måling";
            this.btn_filtrerMåling.UseVisualStyleBackColor = true;
            this.btn_filtrerMåling.Click += new System.EventHandler(this.btn_filtrerMåling_Click);
            // 
            // btn_UfiltrerMåling
            // 
            this.btn_UfiltrerMåling.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_UfiltrerMåling.Location = new System.Drawing.Point(1944, 1104);
            this.btn_UfiltrerMåling.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_UfiltrerMåling.Name = "btn_UfiltrerMåling";
            this.btn_UfiltrerMåling.Size = new System.Drawing.Size(252, 99);
            this.btn_UfiltrerMåling.TabIndex = 31;
            this.btn_UfiltrerMåling.Text = "Ufiltrer måling";
            this.btn_UfiltrerMåling.UseVisualStyleBackColor = true;
            this.btn_UfiltrerMåling.Click += new System.EventHandler(this.btn_UfiltrerMåling_Click);
            // 
            // txtKommentar
            // 
            this.txtKommentar.Location = new System.Drawing.Point(2268, 880);
            this.txtKommentar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtKommentar.Multiline = true;
            this.txtKommentar.Name = "txtKommentar";
            this.txtKommentar.Size = new System.Drawing.Size(316, 388);
            this.txtKommentar.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2260, 812);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(322, 32);
            this.label9.TabIndex = 33;
            this.label9.Text = "Kommentar til målingen:";
            // 
            // numericMinSys
            // 
            this.numericMinSys.Location = new System.Drawing.Point(40, 205);
            this.numericMinSys.Name = "numericMinSys";
            this.numericMinSys.Size = new System.Drawing.Size(125, 38);
            this.numericMinSys.TabIndex = 17;
            this.numericMinSys.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericMaksSys
            // 
            this.numericMaksSys.Location = new System.Drawing.Point(250, 202);
            this.numericMaksSys.Name = "numericMaksSys";
            this.numericMaksSys.Size = new System.Drawing.Size(121, 38);
            this.numericMaksSys.TabIndex = 18;
            this.numericMaksSys.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericMinDia
            // 
            this.numericMinDia.Location = new System.Drawing.Point(40, 323);
            this.numericMinDia.Name = "numericMinDia";
            this.numericMinDia.Size = new System.Drawing.Size(125, 38);
            this.numericMinDia.TabIndex = 19;
            this.numericMinDia.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericMaksDia
            // 
            this.numericMaksDia.Location = new System.Drawing.Point(250, 323);
            this.numericMaksDia.Name = "numericMaksDia";
            this.numericMaksDia.Size = new System.Drawing.Size(121, 38);
            this.numericMaksDia.TabIndex = 20;
            this.numericMaksDia.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // Måling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(2719, 1287);
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_StopMåling);
            this.Controls.Add(this.btn_StartMåling);
            this.Controls.Add(this.btn_Indstillinger);
            this.Controls.Add(this.btn_Nulpunktsjustering);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Måling";
            this.Text = "G3-monitor: Måling";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinSys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaksSys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaksDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Nulpunktsjustering;
        private System.Windows.Forms.Button btn_Indstillinger;
        private System.Windows.Forms.Button btn_StartMåling;
        private System.Windows.Forms.Button btn_StopMåling;
        private System.Windows.Forms.Button btn_DeaktiverAlarm;
        private System.Windows.Forms.Button btn_AktiverAlarm;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericMaksDia;
        private System.Windows.Forms.NumericUpDown numericMinDia;
        private System.Windows.Forms.NumericUpDown numericMaksSys;
        private System.Windows.Forms.NumericUpDown numericMinSys;
    }
}