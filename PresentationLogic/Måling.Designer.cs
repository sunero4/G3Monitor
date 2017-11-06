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
            this.btn_DeaktiverAlarm = new System.Windows.Forms.Button();
            this.btn_AktiverAlarm = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_minimumSys = new System.Windows.Forms.TextBox();
            this.txt_maksimumSys = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_minimumDia = new System.Windows.Forms.TextBox();
            this.txt_maksimumDia = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar4 = new System.Windows.Forms.VScrollBar();
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Nulpunktsjustering
            // 
            this.btn_Nulpunktsjustering.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Nulpunktsjustering.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Nulpunktsjustering.Location = new System.Drawing.Point(74, 62);
            this.btn_Nulpunktsjustering.Name = "btn_Nulpunktsjustering";
            this.btn_Nulpunktsjustering.Size = new System.Drawing.Size(284, 90);
            this.btn_Nulpunktsjustering.TabIndex = 0;
            this.btn_Nulpunktsjustering.Text = "Nulpunktsjustering ";
            this.btn_Nulpunktsjustering.UseVisualStyleBackColor = false;
            // 
            // btn_Indstillinger
            // 
            this.btn_Indstillinger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Indstillinger.Location = new System.Drawing.Point(74, 183);
            this.btn_Indstillinger.Name = "btn_Indstillinger";
            this.btn_Indstillinger.Size = new System.Drawing.Size(284, 89);
            this.btn_Indstillinger.TabIndex = 1;
            this.btn_Indstillinger.Text = "Indstillinger for måling";
            this.btn_Indstillinger.UseVisualStyleBackColor = true;
            // 
            // btn_StartMåling
            // 
            this.btn_StartMåling.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_StartMåling.Location = new System.Drawing.Point(74, 303);
            this.btn_StartMåling.Name = "btn_StartMåling";
            this.btn_StartMåling.Size = new System.Drawing.Size(284, 92);
            this.btn_StartMåling.TabIndex = 2;
            this.btn_StartMåling.Text = "Start måling";
            this.btn_StartMåling.UseVisualStyleBackColor = true;
            // 
            // btn_StopMåling
            // 
            this.btn_StopMåling.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_StopMåling.Location = new System.Drawing.Point(74, 423);
            this.btn_StopMåling.Name = "btn_StopMåling";
            this.btn_StopMåling.Size = new System.Drawing.Size(284, 90);
            this.btn_StopMåling.TabIndex = 3;
            this.btn_StopMåling.Text = "Stop måling";
            this.btn_StopMåling.UseVisualStyleBackColor = true;
            // 
            // btn_DeaktiverAlarm
            // 
            this.btn_DeaktiverAlarm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DeaktiverAlarm.Location = new System.Drawing.Point(38, 422);
            this.btn_DeaktiverAlarm.Name = "btn_DeaktiverAlarm";
            this.btn_DeaktiverAlarm.Size = new System.Drawing.Size(272, 87);
            this.btn_DeaktiverAlarm.TabIndex = 4;
            this.btn_DeaktiverAlarm.Text = "Deaktiver alarm";
            this.btn_DeaktiverAlarm.UseVisualStyleBackColor = true;
            // 
            // btn_AktiverAlarm
            // 
            this.btn_AktiverAlarm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AktiverAlarm.Location = new System.Drawing.Point(38, 541);
            this.btn_AktiverAlarm.Name = "btn_AktiverAlarm";
            this.btn_AktiverAlarm.Size = new System.Drawing.Size(272, 89);
            this.btn_AktiverAlarm.TabIndex = 5;
            this.btn_AktiverAlarm.Text = "Aktiver alarm";
            this.btn_AktiverAlarm.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.TitleForeColor = System.Drawing.Color.White;
            legend1.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(459, 183);
            this.chart1.Name = "chart1";
            series1.BackImageTransparentColor = System.Drawing.Color.White;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.White;
            series1.LabelForeColor = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1486, 1112);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(2038, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Puls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(2038, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sys/Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(2038, 751);
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
            this.label4.Location = new System.Drawing.Point(30, 82);
            this.label4.MaximumSize = new System.Drawing.Size(400, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 64);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ændring af grænseværdier for alam aktivering:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Minimum sys";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Maksimum sys";
            // 
            // txt_minimumSys
            // 
            this.txt_minimumSys.Location = new System.Drawing.Point(37, 222);
            this.txt_minimumSys.Name = "txt_minimumSys";
            this.txt_minimumSys.Size = new System.Drawing.Size(119, 38);
            this.txt_minimumSys.TabIndex = 13;
            // 
            // txt_maksimumSys
            // 
            this.txt_maksimumSys.Location = new System.Drawing.Point(249, 222);
            this.txt_maksimumSys.Name = "txt_maksimumSys";
            this.txt_maksimumSys.Size = new System.Drawing.Size(115, 38);
            this.txt_maksimumSys.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Minimum dia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Maksimum dia";
            // 
            // txt_minimumDia
            // 
            this.txt_minimumDia.Location = new System.Drawing.Point(39, 332);
            this.txt_minimumDia.Name = "txt_minimumDia";
            this.txt_minimumDia.Size = new System.Drawing.Size(117, 38);
            this.txt_minimumDia.TabIndex = 17;
            // 
            // txt_maksimumDia
            // 
            this.txt_maksimumDia.Location = new System.Drawing.Point(249, 332);
            this.txt_maksimumDia.Name = "txt_maksimumDia";
            this.txt_maksimumDia.Size = new System.Drawing.Size(115, 38);
            this.txt_maksimumDia.TabIndex = 18;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(163, 222);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(29, 38);
            this.vScrollBar1.TabIndex = 19;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(369, 222);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(29, 38);
            this.vScrollBar2.TabIndex = 20;
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(163, 332);
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(29, 38);
            this.vScrollBar3.TabIndex = 21;
            // 
            // vScrollBar4
            // 
            this.vScrollBar4.Location = new System.Drawing.Point(370, 333);
            this.vScrollBar4.Name = "vScrollBar4";
            this.vScrollBar4.Size = new System.Drawing.Size(28, 37);
            this.vScrollBar4.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.vScrollBar4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.vScrollBar2);
            this.groupBox1.Controls.Add(this.btn_DeaktiverAlarm);
            this.groupBox1.Controls.Add(this.btn_AktiverAlarm);
            this.groupBox1.Controls.Add(this.vScrollBar3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_minimumSys);
            this.groupBox1.Controls.Add(this.vScrollBar1);
            this.groupBox1.Controls.Add(this.txt_maksimumSys);
            this.groupBox1.Controls.Add(this.txt_maksimumDia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_minimumDia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(38, 611);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 663);
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
            this.label_Puls.Location = new System.Drawing.Point(2244, 372);
            this.label_Puls.MaximumSize = new System.Drawing.Size(100, 100);
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
            this.label_SysDia.Location = new System.Drawing.Point(2244, 562);
            this.label_SysDia.MaximumSize = new System.Drawing.Size(100, 100);
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
            this.label_MiddelBT.Location = new System.Drawing.Point(2244, 701);
            this.label_MiddelBT.MaximumSize = new System.Drawing.Size(100, 100);
            this.label_MiddelBT.Name = "label_MiddelBT";
            this.label_MiddelBT.Size = new System.Drawing.Size(93, 91);
            this.label_MiddelBT.TabIndex = 26;
            this.label_MiddelBT.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2038, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(260, 32);
            this.label12.TabIndex = 27;
            this.label12.Text = "Patientoplysninger:";
            // 
            // txt_patientNavn
            // 
            this.txt_patientNavn.Location = new System.Drawing.Point(2044, 120);
            this.txt_patientNavn.Name = "txt_patientNavn";
            this.txt_patientNavn.Size = new System.Drawing.Size(254, 38);
            this.txt_patientNavn.TabIndex = 28;
            // 
            // txt_patientCPR
            // 
            this.txt_patientCPR.Location = new System.Drawing.Point(2044, 183);
            this.txt_patientCPR.Name = "txt_patientCPR";
            this.txt_patientCPR.Size = new System.Drawing.Size(254, 38);
            this.txt_patientCPR.TabIndex = 29;
            // 
            // btn_filtrerMåling
            // 
            this.btn_filtrerMåling.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_filtrerMåling.Location = new System.Drawing.Point(2044, 977);
            this.btn_filtrerMåling.Name = "btn_filtrerMåling";
            this.btn_filtrerMåling.Size = new System.Drawing.Size(254, 102);
            this.btn_filtrerMåling.TabIndex = 30;
            this.btn_filtrerMåling.Text = "Filtrer måling";
            this.btn_filtrerMåling.UseVisualStyleBackColor = true;
            // 
            // btn_UfiltrerMåling
            // 
            this.btn_UfiltrerMåling.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_UfiltrerMåling.Location = new System.Drawing.Point(2044, 1104);
            this.btn_UfiltrerMåling.Name = "btn_UfiltrerMåling";
            this.btn_UfiltrerMåling.Size = new System.Drawing.Size(254, 98);
            this.btn_UfiltrerMåling.TabIndex = 31;
            this.btn_UfiltrerMåling.Text = "Ufiltrer måling";
            this.btn_UfiltrerMåling.UseVisualStyleBackColor = true;
            // 
            // Måling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(2436, 1328);
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
            this.Name = "Måling";
            this.Text = "G3-monitor: Måling";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_minimumSys;
        private System.Windows.Forms.TextBox txt_maksimumSys;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_minimumDia;
        private System.Windows.Forms.TextBox txt_maksimumDia;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.VScrollBar vScrollBar4;
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
    }
}