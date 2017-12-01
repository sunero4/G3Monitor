namespace PresentationLogic
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrugernavn = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rbtnOP = new System.Windows.Forms.RadioButton();
            this.rbtnTekniker = new System.Windows.Forms.RadioButton();
            this.rbtnStartMål = new System.Windows.Forms.RadioButton();
            this.rbtnHentdata = new System.Windows.Forms.RadioButton();
            this.rbtnStartKalib = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brugernavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtBrugernavn
            // 
            this.txtBrugernavn.Location = new System.Drawing.Point(122, 48);
            this.txtBrugernavn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBrugernavn.Name = "txtBrugernavn";
            this.txtBrugernavn.Size = new System.Drawing.Size(132, 22);
            this.txtBrugernavn.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(122, 84);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(132, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // rbtnOP
            // 
            this.rbtnOP.AutoSize = true;
            this.rbtnOP.Location = new System.Drawing.Point(30, 51);
            this.rbtnOP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnOP.Name = "rbtnOP";
            this.rbtnOP.Size = new System.Drawing.Size(141, 21);
            this.rbtnOP.TabIndex = 5;
            this.rbtnOP.TabStop = true;
            this.rbtnOP.Text = "OP-sygeplejerske";
            this.rbtnOP.UseVisualStyleBackColor = true;
            // 
            // rbtnTekniker
            // 
            this.rbtnTekniker.AutoSize = true;
            this.rbtnTekniker.Location = new System.Drawing.Point(340, 51);
            this.rbtnTekniker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnTekniker.Name = "rbtnTekniker";
            this.rbtnTekniker.Size = new System.Drawing.Size(84, 21);
            this.rbtnTekniker.TabIndex = 6;
            this.rbtnTekniker.TabStop = true;
            this.rbtnTekniker.Text = "Tekniker";
            this.rbtnTekniker.UseVisualStyleBackColor = true;
            // 
            // rbtnStartMål
            // 
            this.rbtnStartMål.AutoSize = true;
            this.rbtnStartMål.Location = new System.Drawing.Point(30, 60);
            this.rbtnStartMål.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnStartMål.Name = "rbtnStartMål";
            this.rbtnStartMål.Size = new System.Drawing.Size(104, 21);
            this.rbtnStartMål.TabIndex = 7;
            this.rbtnStartMål.TabStop = true;
            this.rbtnStartMål.Text = "Start måling";
            this.rbtnStartMål.UseVisualStyleBackColor = true;
            // 
            // rbtnHentdata
            // 
            this.rbtnHentdata.AutoSize = true;
            this.rbtnHentdata.Location = new System.Drawing.Point(194, 60);
            this.rbtnHentdata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnHentdata.Name = "rbtnHentdata";
            this.rbtnHentdata.Size = new System.Drawing.Size(91, 21);
            this.rbtnHentdata.TabIndex = 8;
            this.rbtnHentdata.TabStop = true;
            this.rbtnHentdata.Text = "Hent data";
            this.rbtnHentdata.UseVisualStyleBackColor = true;
            // 
            // rbtnStartKalib
            // 
            this.rbtnStartKalib.AutoSize = true;
            this.rbtnStartKalib.Location = new System.Drawing.Point(340, 60);
            this.rbtnStartKalib.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnStartKalib.Name = "rbtnStartKalib";
            this.rbtnStartKalib.Size = new System.Drawing.Size(129, 21);
            this.rbtnStartKalib.TabIndex = 9;
            this.rbtnStartKalib.TabStop = true;
            this.rbtnStartKalib.Text = "Start kalibrering";
            this.rbtnStartKalib.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(26, 426);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(106, 36);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnTekniker);
            this.groupBox1.Controls.Add(this.rbtnOP);
            this.groupBox1.Location = new System.Drawing.Point(26, 139);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(522, 123);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vælg profession";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnStartMål);
            this.groupBox2.Controls.Add(this.rbtnHentdata);
            this.groupBox2.Controls.Add(this.rbtnStartKalib);
            this.groupBox2.Location = new System.Drawing.Point(26, 276);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(522, 123);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vælg funktion";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(644, 525);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtBrugernavn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "G3-monitor: Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrugernavn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rbtnOP;
        private System.Windows.Forms.RadioButton rbtnTekniker;
        private System.Windows.Forms.RadioButton rbtnStartMål;
        private System.Windows.Forms.RadioButton rbtnHentdata;
        private System.Windows.Forms.RadioButton rbtnStartKalib;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}