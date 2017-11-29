namespace PresentationLogic
{
    partial class HentData
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
            this.lbl_cpr = new System.Windows.Forms.Label();
            this.txt_indtastCpr = new System.Windows.Forms.TextBox();
            this.btn_hentData = new System.Windows.Forms.Button();
            this.lbl_ældreData = new System.Windows.Forms.Label();
            this.combo_ældreData = new System.Windows.Forms.ComboBox();
            this.lbl_kommentarer = new System.Windows.Forms.Label();
            this.txt_kommentarer = new System.Windows.Forms.TextBox();
            this.chart_måling = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_patientOplysninger = new System.Windows.Forms.Label();
            this.txt_patientNavn = new System.Windows.Forms.TextBox();
            this.txt_patientCpr = new System.Windows.Forms.TextBox();
            this.lbl_puls = new System.Windows.Forms.Label();
            this.lbl_sys_dia = new System.Windows.Forms.Label();
            this.lbl_middelBT = new System.Windows.Forms.Label();
            this.lbl_puls_value = new System.Windows.Forms.Label();
            this.lbl_sys_dia_value = new System.Windows.Forms.Label();
            this.lbl_middelBT_value = new System.Windows.Forms.Label();
            this.btn_filtreret = new System.Windows.Forms.Button();
            this.btn_ufiltreret = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.chart_måling)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cpr
            // 
            this.lbl_cpr.AutoSize = true;
            this.lbl_cpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_cpr.Location = new System.Drawing.Point(24, 110);
            this.lbl_cpr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_cpr.Name = "lbl_cpr";
            this.lbl_cpr.Size = new System.Drawing.Size(395, 46);
            this.lbl_cpr.TabIndex = 0;
            this.lbl_cpr.Text = "Indtast patients CPR:";
            // 
            // txt_indtastCpr
            // 
            this.txt_indtastCpr.Location = new System.Drawing.Point(30, 165);
            this.txt_indtastCpr.Margin = new System.Windows.Forms.Padding(6);
            this.txt_indtastCpr.Name = "txt_indtastCpr";
            this.txt_indtastCpr.Size = new System.Drawing.Size(568, 38);
            this.txt_indtastCpr.TabIndex = 1;
            // 
            // btn_hentData
            // 
            this.btn_hentData.Location = new System.Drawing.Point(30, 219);
            this.btn_hentData.Margin = new System.Windows.Forms.Padding(6);
            this.btn_hentData.Name = "btn_hentData";
            this.btn_hentData.Size = new System.Drawing.Size(316, 60);
            this.btn_hentData.TabIndex = 2;
            this.btn_hentData.Text = "Hent data";
            this.btn_hentData.UseVisualStyleBackColor = true;
            this.btn_hentData.Click += new System.EventHandler(this.btn_hentData_Click);
            // 
            // lbl_ældreData
            // 
            this.lbl_ældreData.AutoSize = true;
            this.lbl_ældreData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ældreData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_ældreData.Location = new System.Drawing.Point(24, 413);
            this.lbl_ældreData.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_ældreData.Name = "lbl_ældreData";
            this.lbl_ældreData.Size = new System.Drawing.Size(316, 46);
            this.lbl_ældreData.TabIndex = 3;
            this.lbl_ældreData.Text = "Hent ældre data:";
            // 
            // combo_ældreData
            // 
            this.combo_ældreData.FormattingEnabled = true;
            this.combo_ældreData.Location = new System.Drawing.Point(30, 467);
            this.combo_ældreData.Margin = new System.Windows.Forms.Padding(6);
            this.combo_ældreData.Name = "combo_ældreData";
            this.combo_ældreData.Size = new System.Drawing.Size(568, 39);
            this.combo_ældreData.TabIndex = 4;
            this.combo_ældreData.SelectedIndexChanged += new System.EventHandler(this.combo_ældreData_SelectedIndexChanged);
            // 
            // lbl_kommentarer
            // 
            this.lbl_kommentarer.AutoSize = true;
            this.lbl_kommentarer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kommentarer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_kommentarer.Location = new System.Drawing.Point(24, 719);
            this.lbl_kommentarer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_kommentarer.Name = "lbl_kommentarer";
            this.lbl_kommentarer.Size = new System.Drawing.Size(417, 46);
            this.lbl_kommentarer.TabIndex = 5;
            this.lbl_kommentarer.Text = "Tidligere kommentarer";
            // 
            // txt_kommentarer
            // 
            this.txt_kommentarer.Location = new System.Drawing.Point(30, 773);
            this.txt_kommentarer.Margin = new System.Windows.Forms.Padding(6);
            this.txt_kommentarer.Multiline = true;
            this.txt_kommentarer.Name = "txt_kommentarer";
            this.txt_kommentarer.Size = new System.Drawing.Size(568, 269);
            this.txt_kommentarer.TabIndex = 6;
            // 
            // chart_måling
            // 
            this.chart_måling.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart_måling.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_måling.Legends.Add(legend1);
            this.chart_måling.Location = new System.Drawing.Point(636, 39);
            this.chart_måling.Margin = new System.Windows.Forms.Padding(6);
            this.chart_måling.Name = "chart_måling";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Blodtryk";
            this.chart_måling.Series.Add(series1);
            this.chart_måling.Size = new System.Drawing.Size(2478, 1891);
            this.chart_måling.TabIndex = 7;
            this.chart_måling.Text = "chart1";
            // 
            // lbl_patientOplysninger
            // 
            this.lbl_patientOplysninger.AutoSize = true;
            this.lbl_patientOplysninger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patientOplysninger.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_patientOplysninger.Location = new System.Drawing.Point(3284, 39);
            this.lbl_patientOplysninger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_patientOplysninger.Name = "lbl_patientOplysninger";
            this.lbl_patientOplysninger.Size = new System.Drawing.Size(359, 46);
            this.lbl_patientOplysninger.TabIndex = 8;
            this.lbl_patientOplysninger.Text = "Patientoplysninger:";
            // 
            // txt_patientNavn
            // 
            this.txt_patientNavn.Location = new System.Drawing.Point(3290, 110);
            this.txt_patientNavn.Margin = new System.Windows.Forms.Padding(6);
            this.txt_patientNavn.Name = "txt_patientNavn";
            this.txt_patientNavn.Size = new System.Drawing.Size(448, 38);
            this.txt_patientNavn.TabIndex = 9;
            // 
            // txt_patientCpr
            // 
            this.txt_patientCpr.Location = new System.Drawing.Point(3290, 165);
            this.txt_patientCpr.Margin = new System.Windows.Forms.Padding(6);
            this.txt_patientCpr.Name = "txt_patientCpr";
            this.txt_patientCpr.Size = new System.Drawing.Size(448, 38);
            this.txt_patientCpr.TabIndex = 10;
            // 
            // lbl_puls
            // 
            this.lbl_puls.AutoSize = true;
            this.lbl_puls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puls.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_puls.Location = new System.Drawing.Point(3296, 397);
            this.lbl_puls.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_puls.Name = "lbl_puls";
            this.lbl_puls.Size = new System.Drawing.Size(98, 46);
            this.lbl_puls.TabIndex = 11;
            this.lbl_puls.Text = "Puls";
            // 
            // lbl_sys_dia
            // 
            this.lbl_sys_dia.AutoSize = true;
            this.lbl_sys_dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sys_dia.ForeColor = System.Drawing.Color.Red;
            this.lbl_sys_dia.Location = new System.Drawing.Point(3296, 542);
            this.lbl_sys_dia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_sys_dia.Name = "lbl_sys_dia";
            this.lbl_sys_dia.Size = new System.Drawing.Size(158, 46);
            this.lbl_sys_dia.TabIndex = 12;
            this.lbl_sys_dia.Text = "Sys/Dia";
            // 
            // lbl_middelBT
            // 
            this.lbl_middelBT.AutoSize = true;
            this.lbl_middelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_middelBT.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_middelBT.Location = new System.Drawing.Point(3296, 676);
            this.lbl_middelBT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_middelBT.Name = "lbl_middelBT";
            this.lbl_middelBT.Size = new System.Drawing.Size(199, 46);
            this.lbl_middelBT.TabIndex = 13;
            this.lbl_middelBT.Text = "Middel BT";
            // 
            // lbl_puls_value
            // 
            this.lbl_puls_value.AutoSize = true;
            this.lbl_puls_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puls_value.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_puls_value.Location = new System.Drawing.Point(3510, 364);
            this.lbl_puls_value.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_puls_value.Name = "lbl_puls_value";
            this.lbl_puls_value.Size = new System.Drawing.Size(127, 91);
            this.lbl_puls_value.TabIndex = 14;
            this.lbl_puls_value.Text = "80";
            // 
            // lbl_sys_dia_value
            // 
            this.lbl_sys_dia_value.AutoSize = true;
            this.lbl_sys_dia_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sys_dia_value.ForeColor = System.Drawing.Color.Red;
            this.lbl_sys_dia_value.Location = new System.Drawing.Point(3510, 510);
            this.lbl_sys_dia_value.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_sys_dia_value.Name = "lbl_sys_dia_value";
            this.lbl_sys_dia_value.Size = new System.Drawing.Size(281, 91);
            this.lbl_sys_dia_value.TabIndex = 15;
            this.lbl_sys_dia_value.Text = "120/60";
            // 
            // lbl_middelBT_value
            // 
            this.lbl_middelBT_value.AutoSize = true;
            this.lbl_middelBT_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_middelBT_value.ForeColor = System.Drawing.Color.Turquoise;
            this.lbl_middelBT_value.Location = new System.Drawing.Point(3510, 643);
            this.lbl_middelBT_value.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_middelBT_value.Name = "lbl_middelBT_value";
            this.lbl_middelBT_value.Size = new System.Drawing.Size(127, 91);
            this.lbl_middelBT_value.TabIndex = 16;
            this.lbl_middelBT_value.Text = "80";
            // 
            // btn_filtreret
            // 
            this.btn_filtreret.Location = new System.Drawing.Point(3302, 820);
            this.btn_filtreret.Margin = new System.Windows.Forms.Padding(6);
            this.btn_filtreret.Name = "btn_filtreret";
            this.btn_filtreret.Size = new System.Drawing.Size(490, 194);
            this.btn_filtreret.TabIndex = 17;
            this.btn_filtreret.Text = "Filtrer måling";
            this.btn_filtreret.UseVisualStyleBackColor = true;
            // 
            // btn_ufiltreret
            // 
            this.btn_ufiltreret.Location = new System.Drawing.Point(3306, 1025);
            this.btn_ufiltreret.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ufiltreret.Name = "btn_ufiltreret";
            this.btn_ufiltreret.Size = new System.Drawing.Size(490, 194);
            this.btn_ufiltreret.TabIndex = 18;
            this.btn_ufiltreret.Text = "Filtrer måling";
            this.btn_ufiltreret.UseVisualStyleBackColor = true;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(840, 1788);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1894, 21);
            this.hScrollBar1.TabIndex = 19;
            // 
            // HentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(3812, 2009);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.btn_ufiltreret);
            this.Controls.Add(this.btn_filtreret);
            this.Controls.Add(this.lbl_middelBT_value);
            this.Controls.Add(this.lbl_sys_dia_value);
            this.Controls.Add(this.lbl_puls_value);
            this.Controls.Add(this.lbl_middelBT);
            this.Controls.Add(this.lbl_sys_dia);
            this.Controls.Add(this.lbl_puls);
            this.Controls.Add(this.txt_patientCpr);
            this.Controls.Add(this.txt_patientNavn);
            this.Controls.Add(this.lbl_patientOplysninger);
            this.Controls.Add(this.chart_måling);
            this.Controls.Add(this.txt_kommentarer);
            this.Controls.Add(this.lbl_kommentarer);
            this.Controls.Add(this.combo_ældreData);
            this.Controls.Add(this.lbl_ældreData);
            this.Controls.Add(this.btn_hentData);
            this.Controls.Add(this.txt_indtastCpr);
            this.Controls.Add(this.lbl_cpr);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HentData";
            this.Text = "G3-monitor: Hent data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HentData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_måling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cpr;
        private System.Windows.Forms.TextBox txt_indtastCpr;
        private System.Windows.Forms.Button btn_hentData;
        private System.Windows.Forms.Label lbl_ældreData;
        private System.Windows.Forms.ComboBox combo_ældreData;
        private System.Windows.Forms.Label lbl_kommentarer;
        private System.Windows.Forms.TextBox txt_kommentarer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_måling;
        private System.Windows.Forms.Label lbl_patientOplysninger;
        private System.Windows.Forms.TextBox txt_patientNavn;
        private System.Windows.Forms.TextBox txt_patientCpr;
        private System.Windows.Forms.Label lbl_puls;
        private System.Windows.Forms.Label lbl_sys_dia;
        private System.Windows.Forms.Label lbl_middelBT;
        private System.Windows.Forms.Label lbl_puls_value;
        private System.Windows.Forms.Label lbl_sys_dia_value;
        private System.Windows.Forms.Label lbl_middelBT_value;
        private System.Windows.Forms.Button btn_filtreret;
        private System.Windows.Forms.Button btn_ufiltreret;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}