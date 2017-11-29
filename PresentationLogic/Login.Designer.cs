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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brugernavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtBrugernavn
            // 
            this.txtBrugernavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrugernavn.Location = new System.Drawing.Point(320, 98);
            this.txtBrugernavn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtBrugernavn.Name = "txtBrugernavn";
            this.txtBrugernavn.Size = new System.Drawing.Size(260, 61);
            this.txtBrugernavn.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(320, 179);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(260, 61);
            this.txtPassword.TabIndex = 3;
            // 
            // rbtnOP
            // 
            this.rbtnOP.AutoSize = true;
            this.rbtnOP.Location = new System.Drawing.Point(61, 98);
            this.rbtnOP.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rbtnOP.Name = "rbtnOP";
            this.rbtnOP.Size = new System.Drawing.Size(324, 43);
            this.rbtnOP.TabIndex = 5;
            this.rbtnOP.TabStop = true;
            this.rbtnOP.Text = "OP-sygeplejerske";
            this.rbtnOP.UseVisualStyleBackColor = true;
            // 
            // rbtnTekniker
            // 
            this.rbtnTekniker.AutoSize = true;
            this.rbtnTekniker.Location = new System.Drawing.Point(680, 98);
            this.rbtnTekniker.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rbtnTekniker.Name = "rbtnTekniker";
            this.rbtnTekniker.Size = new System.Drawing.Size(186, 43);
            this.rbtnTekniker.TabIndex = 6;
            this.rbtnTekniker.TabStop = true;
            this.rbtnTekniker.Text = "Tekniker";
            this.rbtnTekniker.UseVisualStyleBackColor = true;
            // 
            // rbtnStartMål
            // 
            this.rbtnStartMål.AutoSize = true;
            this.rbtnStartMål.Location = new System.Drawing.Point(61, 117);
            this.rbtnStartMål.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rbtnStartMål.Name = "rbtnStartMål";
            this.rbtnStartMål.Size = new System.Drawing.Size(236, 43);
            this.rbtnStartMål.TabIndex = 7;
            this.rbtnStartMål.TabStop = true;
            this.rbtnStartMål.Text = "Start måling";
            this.rbtnStartMål.UseVisualStyleBackColor = true;
            // 
            // rbtnHentdata
            // 
            this.rbtnHentdata.AutoSize = true;
            this.rbtnHentdata.Location = new System.Drawing.Point(389, 117);
            this.rbtnHentdata.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rbtnHentdata.Name = "rbtnHentdata";
            this.rbtnHentdata.Size = new System.Drawing.Size(202, 43);
            this.rbtnHentdata.TabIndex = 8;
            this.rbtnHentdata.TabStop = true;
            this.rbtnHentdata.Text = "Hent data";
            this.rbtnHentdata.UseVisualStyleBackColor = true;
            // 
            // rbtnStartKalib
            // 
            this.rbtnStartKalib.AutoSize = true;
            this.rbtnStartKalib.Location = new System.Drawing.Point(680, 117);
            this.rbtnStartKalib.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rbtnStartKalib.Name = "rbtnStartKalib";
            this.rbtnStartKalib.Size = new System.Drawing.Size(293, 43);
            this.rbtnStartKalib.TabIndex = 9;
            this.rbtnStartKalib.TabStop = true;
            this.rbtnStartKalib.Text = "Start kalibrering";
            this.rbtnStartKalib.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(51, 907);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(245, 81);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnTekniker);
            this.groupBox1.Controls.Add(this.rbtnOP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 314);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(1043, 238);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vælg profession";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnStartMål);
            this.groupBox2.Controls.Add(this.rbtnHentdata);
            this.groupBox2.Controls.Add(this.rbtnStartKalib);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(51, 616);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(1043, 238);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vælg funktion";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 1185);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtBrugernavn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
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