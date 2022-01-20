
namespace Raph
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.newAccInfo = new System.Windows.Forms.Label();
            this.loginBtn = new FontAwesome.Sharp.IconButton();
            this.pswTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.shadowPanel = new System.Windows.Forms.Panel();
            this.CenterPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CenterPanel
            // 
            this.CenterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(27)))), ((int)(((byte)(146)))));
            this.CenterPanel.Controls.Add(this.LoginPanel);
            this.CenterPanel.Controls.Add(this.shadowPanel);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(0, 0);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(1378, 694);
            this.CenterPanel.TabIndex = 0;
            this.CenterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CenterPanel_Paint);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.LoginPanel.Controls.Add(this.SignUpBtn);
            this.LoginPanel.Controls.Add(this.newAccInfo);
            this.LoginPanel.Controls.Add(this.loginBtn);
            this.LoginPanel.Controls.Add(this.pswTxtBox);
            this.LoginPanel.Controls.Add(this.emailTxtBox);
            this.LoginPanel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginPanel.Location = new System.Drawing.Point(458, 141);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Padding = new System.Windows.Forms.Padding(20);
            this.LoginPanel.Size = new System.Drawing.Size(453, 408);
            this.LoginPanel.TabIndex = 0;
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.FlatAppearance.BorderSize = 0;
            this.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignUpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SignUpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignUpBtn.Location = new System.Drawing.Point(305, 312);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(81, 36);
            this.SignUpBtn.TabIndex = 4;
            this.SignUpBtn.Text = "SignUp";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // newAccInfo
            // 
            this.newAccInfo.AutoSize = true;
            this.newAccInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newAccInfo.Location = new System.Drawing.Point(182, 318);
            this.newAccInfo.Name = "newAccInfo";
            this.newAccInfo.Size = new System.Drawing.Size(135, 25);
            this.newAccInfo.TabIndex = 3;
            this.newAccInfo.Text = "New Account ? ";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.loginBtn.IconColor = System.Drawing.Color.Black;
            this.loginBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loginBtn.Location = new System.Drawing.Point(63, 242);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(323, 59);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pswTxtBox
            // 
            this.pswTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pswTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pswTxtBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.pswTxtBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pswTxtBox.Location = new System.Drawing.Point(63, 167);
            this.pswTxtBox.Name = "pswTxtBox";
            this.pswTxtBox.PasswordChar = '*';
            this.pswTxtBox.PlaceholderText = "password";
            this.pswTxtBox.Size = new System.Drawing.Size(319, 45);
            this.pswTxtBox.TabIndex = 1;
            this.pswTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pswTxtBox.TextChanged += new System.EventHandler(this.pswTxtBox_TextChanged);
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTxtBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.emailTxtBox.Location = new System.Drawing.Point(63, 101);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.PlaceholderText = "e-mail";
            this.emailTxtBox.Size = new System.Drawing.Size(319, 45);
            this.emailTxtBox.TabIndex = 0;
            this.emailTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailTxtBox.TextChanged += new System.EventHandler(this.emailTxtBox_TextChanged);
            // 
            // shadowPanel
            // 
            this.shadowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.shadowPanel.Location = new System.Drawing.Point(452, 136);
            this.shadowPanel.Name = "shadowPanel";
            this.shadowPanel.Size = new System.Drawing.Size(462, 417);
            this.shadowPanel.TabIndex = 1;
            this.shadowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 694);
            this.Controls.Add(this.CenterPanel);
            this.MaximumSize = new System.Drawing.Size(1400, 750);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raph";
            this.CenterPanel.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button SignUpBtn;
        private FontAwesome.Sharp.IconButton loginBtn;
        private System.Windows.Forms.TextBox pswTxtBox;
        private System.Windows.Forms.TextBox emailTxtBox;
        internal System.Windows.Forms.Label newAccInfo;
        private System.Windows.Forms.Panel shadowPanel;
    }
}

