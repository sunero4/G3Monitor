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
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnOP = new System.Windows.Forms.RadioButton();
            this.rbtnTekniker = new System.Windows.Forms.RadioButton();
            this.rbtnStartMål = new System.Windows.Forms.RadioButton();
            this.rbtnHentdata = new System.Windows.Forms.RadioButton();
            this.rbtnStartKalib = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brugernavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtBrugernavn
            // 
            this.txtBrugernavn.Location = new System.Drawing.Point(91, 39);
            this.txtBrugernavn.Name = "txtBrugernavn";
            this.txtBrugernavn.Size = new System.Drawing.Size(100, 20);
            this.txtBrugernavn.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(91, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vælg profession";
            // 
            // rbtnOP
            // 
            this.rbtnOP.AutoSize = true;
            this.rbtnOP.Location = new System.Drawing.Point(13, 128);
            this.rbtnOP.Name = "rbtnOP";
            this.rbtnOP.Size = new System.Drawing.Size(107, 17);
            this.rbtnOP.TabIndex = 5;
            this.rbtnOP.TabStop = true;
            this.rbtnOP.Text = "OP-sygeplejerske";
            this.rbtnOP.UseVisualStyleBackColor = true;
            // 
            // rbtnTekniker
            // 
            this.rbtnTekniker.AutoSize = true;
            this.rbtnTekniker.Location = new System.Drawing.Point(161, 128);
            this.rbtnTekniker.Name = "rbtnTekniker";
            this.rbtnTekniker.Size = new System.Drawing.Size(67, 17);
            this.rbtnTekniker.TabIndex = 6;
            this.rbtnTekniker.TabStop = true;
            this.rbtnTekniker.Text = "Tekniker";
            this.rbtnTekniker.UseVisualStyleBackColor = true;
            // 
            // rbtnStartMål
            // 
            this.rbtnStartMål.AutoSize = true;
            this.rbtnStartMål.Location = new System.Drawing.Point(13, 184);
            this.rbtnStartMål.Name = "rbtnStartMål";
            this.rbtnStartMål.Size = new System.Drawing.Size(80, 17);
            this.rbtnStartMål.TabIndex = 7;
            this.rbtnStartMål.TabStop = true;
            this.rbtnStartMål.Text = "Start måling";
            this.rbtnStartMål.UseVisualStyleBackColor = true;
            // 
            // rbtnHentdata
            // 
            this.rbtnHentdata.AutoSize = true;
            this.rbtnHentdata.Location = new System.Drawing.Point(161, 184);
            this.rbtnHentdata.Name = "rbtnHentdata";
            this.rbtnHentdata.Size = new System.Drawing.Size(72, 17);
            this.rbtnHentdata.TabIndex = 8;
            this.rbtnHentdata.TabStop = true;
            this.rbtnHentdata.Text = "Hent data";
            this.rbtnHentdata.UseVisualStyleBackColor = true;
            // 
            // rbtnStartKalib
            // 
            this.rbtnStartKalib.AutoSize = true;
            this.rbtnStartKalib.Location = new System.Drawing.Point(271, 184);
            this.rbtnStartKalib.Name = "rbtnStartKalib";
            this.rbtnStartKalib.Size = new System.Drawing.Size(98, 17);
            this.rbtnStartKalib.TabIndex = 9;
            this.rbtnStartKalib.TabStop = true;
            this.rbtnStartKalib.Text = "Start kalibrering";
            this.rbtnStartKalib.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(16, 223);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 29);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vælg funktion";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 350);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.rbtnStartKalib);
            this.Controls.Add(this.rbtnHentdata);
            this.Controls.Add(this.rbtnStartMål);
            this.Controls.Add(this.rbtnTekniker);
            this.Controls.Add(this.rbtnOP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtBrugernavn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "G3-monitor: Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrugernavn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnOP;
        private System.Windows.Forms.RadioButton rbtnTekniker;
        private System.Windows.Forms.RadioButton rbtnStartMål;
        private System.Windows.Forms.RadioButton rbtnHentdata;
        private System.Windows.Forms.RadioButton rbtnStartKalib;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
    }
}