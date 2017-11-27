namespace PresentationLogic
{
    partial class Maaleindstillinger
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnØnskerIKKEGem = new System.Windows.Forms.RadioButton();
            this.rbtnØnskerGem = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaksDia = new System.Windows.Forms.TextBox();
            this.txtMaksSys = new System.Windows.Forms.TextBox();
            this.txtMinsys = new System.Windows.Forms.TextBox();
            this.txtMinDia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGemIndstillinger = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKommentar = new System.Windows.Forms.TextBox();
            this.txtEfternavn = new System.Windows.Forms.TextBox();
            this.txtFornavn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFindPatient = new System.Windows.Forms.Button();
            this.txtCPR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnØnskerIKKEGem);
            this.groupBox1.Controls.Add(this.rbtnØnskerGem);
            this.groupBox1.Location = new System.Drawing.Point(31, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indstillinger for at gemme";
            // 
            // rbtnØnskerIKKEGem
            // 
            this.rbtnØnskerIKKEGem.AutoSize = true;
            this.rbtnØnskerIKKEGem.Location = new System.Drawing.Point(222, 31);
            this.rbtnØnskerIKKEGem.Name = "rbtnØnskerIKKEGem";
            this.rbtnØnskerIKKEGem.Size = new System.Drawing.Size(168, 17);
            this.rbtnØnskerIKKEGem.TabIndex = 1;
            this.rbtnØnskerIKKEGem.TabStop = true;
            this.rbtnØnskerIKKEGem.Text = "Ønsker IKKE at gemme måling";
            this.rbtnØnskerIKKEGem.UseVisualStyleBackColor = true;
            // 
            // rbtnØnskerGem
            // 
            this.rbtnØnskerGem.AutoSize = true;
            this.rbtnØnskerGem.Location = new System.Drawing.Point(10, 31);
            this.rbtnØnskerGem.Name = "rbtnØnskerGem";
            this.rbtnØnskerGem.Size = new System.Drawing.Size(141, 17);
            this.rbtnØnskerGem.TabIndex = 0;
            this.rbtnØnskerGem.TabStop = true;
            this.rbtnØnskerGem.Text = "Ønsker at gemme måling";
            this.rbtnØnskerGem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaksDia);
            this.groupBox2.Controls.Add(this.txtMaksSys);
            this.groupBox2.Controls.Add(this.txtMinsys);
            this.groupBox2.Controls.Add(this.txtMinDia);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(31, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 148);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grænseværdier for alarm-aktivering";
            // 
            // txtMaksDia
            // 
            this.txtMaksDia.Location = new System.Drawing.Point(152, 103);
            this.txtMaksDia.Name = "txtMaksDia";
            this.txtMaksDia.Size = new System.Drawing.Size(62, 20);
            this.txtMaksDia.TabIndex = 11;
            // 
            // txtMaksSys
            // 
            this.txtMaksSys.Location = new System.Drawing.Point(152, 42);
            this.txtMaksSys.Name = "txtMaksSys";
            this.txtMaksSys.Size = new System.Drawing.Size(62, 20);
            this.txtMaksSys.TabIndex = 10;
            // 
            // txtMinsys
            // 
            this.txtMinsys.Location = new System.Drawing.Point(9, 42);
            this.txtMinsys.Name = "txtMinsys";
            this.txtMinsys.Size = new System.Drawing.Size(63, 20);
            this.txtMinsys.TabIndex = 9;
            // 
            // txtMinDia
            // 
            this.txtMinDia.Location = new System.Drawing.Point(9, 103);
            this.txtMinDia.Name = "txtMinDia";
            this.txtMinDia.Size = new System.Drawing.Size(62, 20);
            this.txtMinDia.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maksimum dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Maksimum sys";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minimum sys";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Minimum dia";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGemIndstillinger);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtKommentar);
            this.groupBox3.Controls.Add(this.txtEfternavn);
            this.groupBox3.Controls.Add(this.txtFornavn);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnFindPatient);
            this.groupBox3.Controls.Add(this.txtCPR);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(31, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 271);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Indtast patientoplysninger";
            // 
            // btnGemIndstillinger
            // 
            this.btnGemIndstillinger.Location = new System.Drawing.Point(279, 167);
            this.btnGemIndstillinger.Name = "btnGemIndstillinger";
            this.btnGemIndstillinger.Size = new System.Drawing.Size(111, 52);
            this.btnGemIndstillinger.TabIndex = 9;
            this.btnGemIndstillinger.Text = "Gem indstillinger for denne måling";
            this.btnGemIndstillinger.UseVisualStyleBackColor = true;
            this.btnGemIndstillinger.Click += new System.EventHandler(this.btnGemIndstillinger_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Evt. kommentarer";
            // 
            // txtKommentar
            // 
            this.txtKommentar.Location = new System.Drawing.Point(10, 167);
            this.txtKommentar.Multiline = true;
            this.txtKommentar.Name = "txtKommentar";
            this.txtKommentar.Size = new System.Drawing.Size(242, 85);
            this.txtKommentar.TabIndex = 7;
            // 
            // txtEfternavn
            // 
            this.txtEfternavn.Location = new System.Drawing.Point(152, 105);
            this.txtEfternavn.Name = "txtEfternavn";
            this.txtEfternavn.Size = new System.Drawing.Size(100, 20);
            this.txtEfternavn.TabIndex = 6;
            // 
            // txtFornavn
            // 
            this.txtFornavn.Location = new System.Drawing.Point(10, 105);
            this.txtFornavn.Name = "txtFornavn";
            this.txtFornavn.Size = new System.Drawing.Size(100, 20);
            this.txtFornavn.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Efternavn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fornavn";
            // 
            // btnFindPatient
            // 
            this.btnFindPatient.Location = new System.Drawing.Point(152, 37);
            this.btnFindPatient.Name = "btnFindPatient";
            this.btnFindPatient.Size = new System.Drawing.Size(75, 40);
            this.btnFindPatient.TabIndex = 2;
            this.btnFindPatient.Text = "Find patient";
            this.btnFindPatient.UseVisualStyleBackColor = true;
            this.btnFindPatient.Click += new System.EventHandler(this.btnFindPatient_Click);
            // 
            // txtCPR
            // 
            this.txtCPR.Location = new System.Drawing.Point(10, 48);
            this.txtCPR.Name = "txtCPR";
            this.txtCPR.Size = new System.Drawing.Size(100, 20);
            this.txtCPR.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CPR-nummer*";
            // 
            // Maaleindstillinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 525);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Maaleindstillinger";
            this.Text = "G3-monitor: Måleindstillinger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnØnskerIKKEGem;
        private System.Windows.Forms.RadioButton rbtnØnskerGem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaksDia;
        private System.Windows.Forms.TextBox txtMaksSys;
        private System.Windows.Forms.TextBox txtMinsys;
        private System.Windows.Forms.TextBox txtMinDia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGemIndstillinger;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKommentar;
        private System.Windows.Forms.TextBox txtEfternavn;
        private System.Windows.Forms.TextBox txtFornavn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFindPatient;
        private System.Windows.Forms.TextBox txtCPR;
        private System.Windows.Forms.Label label5;
    }
}