namespace TreeTop.PLL
{
    partial class frmAdminManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.panelBill = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.btnAcount = new System.Windows.Forms.Button();
            this.btnTree = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblThanks = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelBill.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.panelBill);
            this.panel1.Controls.Add(this.btnBill);
            this.panel1.Controls.Add(this.panelGeneral);
            this.panel1.Controls.Add(this.btnManager);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 561);
            this.panel1.TabIndex = 0;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignOut.Location = new System.Drawing.Point(0, 365);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSignOut.Size = new System.Drawing.Size(200, 45);
            this.btnSignOut.TabIndex = 13;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // panelBill
            // 
            this.panelBill.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelBill.Controls.Add(this.btnView);
            this.panelBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBill.Location = new System.Drawing.Point(0, 314);
            this.panelBill.Name = "panelBill";
            this.panelBill.Size = new System.Drawing.Size(200, 51);
            this.panelBill.TabIndex = 9;
            // 
            // btnView
            // 
            this.btnView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnView.Location = new System.Drawing.Point(0, 0);
            this.btnView.Name = "btnView";
            this.btnView.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnView.Size = new System.Drawing.Size(200, 40);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View Bill";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBill.Location = new System.Drawing.Point(0, 269);
            this.btnBill.Name = "btnBill";
            this.btnBill.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBill.Size = new System.Drawing.Size(200, 45);
            this.btnBill.TabIndex = 8;
            this.btnBill.Text = "Bill Manager";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelGeneral.Controls.Add(this.btnAcount);
            this.panelGeneral.Controls.Add(this.btnTree);
            this.panelGeneral.Controls.Add(this.btnCategory);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.Location = new System.Drawing.Point(0, 145);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(200, 124);
            this.panelGeneral.TabIndex = 7;
            // 
            // btnAcount
            // 
            this.btnAcount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcount.FlatAppearance.BorderSize = 0;
            this.btnAcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcount.Location = new System.Drawing.Point(0, 80);
            this.btnAcount.Name = "btnAcount";
            this.btnAcount.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAcount.Size = new System.Drawing.Size(200, 40);
            this.btnAcount.TabIndex = 2;
            this.btnAcount.Text = "Account Manager";
            this.btnAcount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcount.UseVisualStyleBackColor = true;
            this.btnAcount.Click += new System.EventHandler(this.btnAcount_Click);
            // 
            // btnTree
            // 
            this.btnTree.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTree.FlatAppearance.BorderSize = 0;
            this.btnTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTree.Location = new System.Drawing.Point(0, 40);
            this.btnTree.Name = "btnTree";
            this.btnTree.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTree.Size = new System.Drawing.Size(200, 40);
            this.btnTree.TabIndex = 1;
            this.btnTree.Text = "Tree Manager";
            this.btnTree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTree.UseVisualStyleBackColor = true;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCategory.Location = new System.Drawing.Point(0, 0);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCategory.Size = new System.Drawing.Size(200, 40);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Category Manager";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManager.FlatAppearance.BorderSize = 0;
            this.btnManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManager.Location = new System.Drawing.Point(0, 100);
            this.btnManager.Name = "btnManager";
            this.btnManager.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManager.Size = new System.Drawing.Size(200, 45);
            this.btnManager.TabIndex = 6;
            this.btnManager.Text = "General Manager";
            this.btnManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManager.UseVisualStyleBackColor = false;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 76);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblThanks);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(200, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 100);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(295, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 1);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "HI, WE\'RE THE TREE CENTER";
            // 
            // lblThanks
            // 
            this.lblThanks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.Location = new System.Drawing.Point(221, 58);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(307, 18);
            this.lblThanks.TabIndex = 0;
            this.lblThanks.Text = "We grow and deliver trees to your door.";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(734, 461);
            this.panelChildForm.TabIndex = 4;
            // 
            // frmAdminManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(950, 600);
            this.Name = "frmAdminManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminManager";
            this.panel1.ResumeLayout(false);
            this.panelBill.ResumeLayout(false);
            this.panelGeneral.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Button btnAcount;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBill;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSignOut;
    }
}