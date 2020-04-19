namespace TreeTop
{
    partial class frmLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lkRegister = new System.Windows.Forms.LinkLabel();
            this.btnSeePass = new System.Windows.Forms.Button();
            this.txtPassCha = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.errorMSG = new System.Windows.Forms.Label();
            this.linkForgotPassword = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 76);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 53);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 225);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 50);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(111, 238);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(123, 26);
            this.txtPass.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(111, 144);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(123, 26);
            this.txtUser.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(125, 305);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(92, 32);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lkRegister
            // 
            this.lkRegister.AutoSize = true;
            this.lkRegister.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkRegister.Location = new System.Drawing.Point(72, 361);
            this.lkRegister.Name = "lkRegister";
            this.lkRegister.Size = new System.Drawing.Size(198, 24);
            this.lkRegister.TabIndex = 6;
            this.lkRegister.TabStop = true;
            this.lkRegister.Text = "Create a new account?";
            this.lkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkRegister_LinkClicked);
            // 
            // btnSeePass
            // 
            this.btnSeePass.BackColor = System.Drawing.Color.Beige;
            this.btnSeePass.Location = new System.Drawing.Point(240, 240);
            this.btnSeePass.Name = "btnSeePass";
            this.btnSeePass.Size = new System.Drawing.Size(19, 20);
            this.btnSeePass.TabIndex = 7;
            this.btnSeePass.UseVisualStyleBackColor = false;
            this.btnSeePass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSeePass_MouseDown);
            this.btnSeePass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSeePass_MouseUp);
            // 
            // txtPassCha
            // 
            this.txtPassCha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassCha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassCha.Location = new System.Drawing.Point(111, 238);
            this.txtPassCha.Name = "txtPassCha";
            this.txtPassCha.PasswordChar = '*';
            this.txtPassCha.Size = new System.Drawing.Size(123, 26);
            this.txtPassCha.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "TreeTop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorMSG
            // 
            this.errorMSG.AutoSize = true;
            this.errorMSG.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMSG.Location = new System.Drawing.Point(108, 279);
            this.errorMSG.Name = "errorMSG";
            this.errorMSG.Size = new System.Drawing.Size(0, 15);
            this.errorMSG.TabIndex = 10;
            // 
            // linkForgotPassword
            // 
            this.linkForgotPassword.AutoSize = true;
            this.linkForgotPassword.Location = new System.Drawing.Point(116, 398);
            this.linkForgotPassword.Name = "linkForgotPassword";
            this.linkForgotPassword.Size = new System.Drawing.Size(117, 13);
            this.linkForgotPassword.TabIndex = 11;
            this.linkForgotPassword.TabStop = true;
            this.linkForgotPassword.Text = "Missed your password?";
            this.linkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.linkForgotPassword);
            this.Controls.Add(this.errorMSG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassCha);
            this.Controls.Add(this.btnSeePass);
            this.Controls.Add(this.lkRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoginForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lkRegister;
        private System.Windows.Forms.Button btnSeePass;
        private System.Windows.Forms.TextBox txtPassCha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorMSG;
        private System.Windows.Forms.LinkLabel linkForgotPassword;
    }
}

