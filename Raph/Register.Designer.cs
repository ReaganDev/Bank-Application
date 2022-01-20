
namespace Raph
{
    partial class Register
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
            this.centerPanel = new System.Windows.Forms.Panel();
            this.regPanel = new System.Windows.Forms.Panel();
            this.nextBtn = new System.Windows.Forms.Button();
            this.pswTxtBox = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.emailTxtbox = new System.Windows.Forms.TextBox();
            this.LastNameTxtbox = new System.Windows.Forms.TextBox();
            this.firstNameTxtbox = new System.Windows.Forms.TextBox();
            this.shadowPanel = new System.Windows.Forms.Panel();
            this.centerPanel.SuspendLayout();
            this.regPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.centerPanel.Controls.Add(this.regPanel);
            this.centerPanel.Controls.Add(this.shadowPanel);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1378, 694);
            this.centerPanel.TabIndex = 0;
            this.centerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.centerPanel_Paint);
            // 
            // regPanel
            // 
            this.regPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.regPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regPanel.Controls.Add(this.nextBtn);
            this.regPanel.Controls.Add(this.pswTxtBox);
            this.regPanel.Controls.Add(this.phoneTxt);
            this.regPanel.Controls.Add(this.emailTxtbox);
            this.regPanel.Controls.Add(this.LastNameTxtbox);
            this.regPanel.Controls.Add(this.firstNameTxtbox);
            this.regPanel.Location = new System.Drawing.Point(430, 125);
            this.regPanel.Name = "regPanel";
            this.regPanel.Size = new System.Drawing.Size(475, 444);
            this.regPanel.TabIndex = 0;
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.Location = new System.Drawing.Point(59, 351);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(360, 54);
            this.nextBtn.TabIndex = 5;
            this.nextBtn.Text = "NEXT";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // pswTxtBox
            // 
            this.pswTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pswTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pswTxtBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pswTxtBox.Location = new System.Drawing.Point(58, 304);
            this.pswTxtBox.Name = "pswTxtBox";
            this.pswTxtBox.PasswordChar = '*';
            this.pswTxtBox.PlaceholderText = "Create Password";
            this.pswTxtBox.Size = new System.Drawing.Size(362, 45);
            this.pswTxtBox.TabIndex = 4;
            this.pswTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pswTxtBox.TextChanged += new System.EventHandler(this.pswTxtBox_TextChanged);
            // 
            // phoneTxt
            // 
            this.phoneTxt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneTxt.Location = new System.Drawing.Point(58, 224);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.PlaceholderText = "Phone_No";
            this.phoneTxt.Size = new System.Drawing.Size(364, 45);
            this.phoneTxt.TabIndex = 3;
            this.phoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneTxt.TextChanged += new System.EventHandler(this.phoneTxt_TextChanged);
            // 
            // emailTxtbox
            // 
            this.emailTxtbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailTxtbox.Location = new System.Drawing.Point(58, 178);
            this.emailTxtbox.Name = "emailTxtbox";
            this.emailTxtbox.PlaceholderText = "E-Mail";
            this.emailTxtbox.Size = new System.Drawing.Size(364, 45);
            this.emailTxtbox.TabIndex = 2;
            this.emailTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailTxtbox.TextChanged += new System.EventHandler(this.emailTxtbox_TextChanged);
            // 
            // LastNameTxtbox
            // 
            this.LastNameTxtbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameTxtbox.Location = new System.Drawing.Point(57, 104);
            this.LastNameTxtbox.Name = "LastNameTxtbox";
            this.LastNameTxtbox.PlaceholderText = "Last Name";
            this.LastNameTxtbox.Size = new System.Drawing.Size(362, 45);
            this.LastNameTxtbox.TabIndex = 1;
            this.LastNameTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastNameTxtbox.TextChanged += new System.EventHandler(this.LastNameTxtbox_TextChanged);
            // 
            // firstNameTxtbox
            // 
            this.firstNameTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTxtbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameTxtbox.Location = new System.Drawing.Point(57, 58);
            this.firstNameTxtbox.Name = "firstNameTxtbox";
            this.firstNameTxtbox.PlaceholderText = " First Name";
            this.firstNameTxtbox.Size = new System.Drawing.Size(362, 45);
            this.firstNameTxtbox.TabIndex = 0;
            this.firstNameTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstNameTxtbox.TextChanged += new System.EventHandler(this.firstNameTxtbox_TextChanged);
            // 
            // shadowPanel
            // 
            this.shadowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.shadowPanel.Location = new System.Drawing.Point(426, 121);
            this.shadowPanel.Name = "shadowPanel";
            this.shadowPanel.Size = new System.Drawing.Size(480, 450);
            this.shadowPanel.TabIndex = 1;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 694);
            this.Controls.Add(this.centerPanel);
            this.MaximumSize = new System.Drawing.Size(1400, 750);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.centerPanel.ResumeLayout(false);
            this.regPanel.ResumeLayout(false);
            this.regPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel regPanel;
        private System.Windows.Forms.TextBox LastNameTxtbox;
        private System.Windows.Forms.TextBox firstNameTxtbox;
        private System.Windows.Forms.TextBox emailTxtbox;
        private System.Windows.Forms.TextBox pswTxtBox;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Panel shadowPanel;
    }
}