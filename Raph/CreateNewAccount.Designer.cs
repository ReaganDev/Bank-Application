
namespace Raph
{
    partial class CreateNewAccount
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
            this.savingsRbtn = new System.Windows.Forms.RadioButton();
            this.currentRbtn = new System.Windows.Forms.RadioButton();
            this.newAcctBtn = new System.Windows.Forms.Button();
            this.amtTxtBox = new System.Windows.Forms.TextBox();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.centerPanel.Controls.Add(this.amtTxtBox);
            this.centerPanel.Controls.Add(this.newAcctBtn);
            this.centerPanel.Controls.Add(this.currentRbtn);
            this.centerPanel.Controls.Add(this.savingsRbtn);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.ForeColor = System.Drawing.Color.White;
            this.centerPanel.Location = new System.Drawing.Point(0, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(458, 394);
            this.centerPanel.TabIndex = 0;
            this.centerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CenterPanel_Paint);
            // 
            // savingsRbtn
            // 
            this.savingsRbtn.AutoSize = true;
            this.savingsRbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.savingsRbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.savingsRbtn.Location = new System.Drawing.Point(114, 102);
            this.savingsRbtn.Name = "savingsRbtn";
            this.savingsRbtn.Size = new System.Drawing.Size(216, 36);
            this.savingsRbtn.TabIndex = 0;
            this.savingsRbtn.TabStop = true;
            this.savingsRbtn.Text = "Savings Account";
            this.savingsRbtn.UseVisualStyleBackColor = true;
            this.savingsRbtn.CheckedChanged += new System.EventHandler(this.SavingsRbtn_CheckedChanged);
            // 
            // currentRbtn
            // 
            this.currentRbtn.AutoSize = true;
            this.currentRbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.currentRbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.currentRbtn.Location = new System.Drawing.Point(114, 144);
            this.currentRbtn.Name = "currentRbtn";
            this.currentRbtn.Size = new System.Drawing.Size(214, 36);
            this.currentRbtn.TabIndex = 1;
            this.currentRbtn.TabStop = true;
            this.currentRbtn.Text = "Current Account";
            this.currentRbtn.UseVisualStyleBackColor = true;
            this.currentRbtn.CheckedChanged += new System.EventHandler(this.CurrentButton2_CheckedChanged);
            // 
            // newAcctBtn
            // 
            this.newAcctBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.newAcctBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.newAcctBtn.FlatAppearance.BorderSize = 2;
            this.newAcctBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newAcctBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newAcctBtn.Location = new System.Drawing.Point(148, 266);
            this.newAcctBtn.Name = "newAcctBtn";
            this.newAcctBtn.Size = new System.Drawing.Size(149, 52);
            this.newAcctBtn.TabIndex = 2;
            this.newAcctBtn.Text = "Create";
            this.newAcctBtn.UseVisualStyleBackColor = false;
            this.newAcctBtn.Click += new System.EventHandler(this.NewAcctBtn_Click);
            // 
            // amtTxtBox
            // 
            this.amtTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amtTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.amtTxtBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.amtTxtBox.Location = new System.Drawing.Point(73, 209);
            this.amtTxtBox.Name = "amtTxtBox";
            this.amtTxtBox.PlaceholderText = "Amount";
            this.amtTxtBox.Size = new System.Drawing.Size(293, 40);
            this.amtTxtBox.TabIndex = 3;
            this.amtTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 394);
            this.Controls.Add(this.centerPanel);
            this.MaximumSize = new System.Drawing.Size(480, 450);
            this.Name = "CreateNewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewAccount";
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.TextBox amtTxtBox;
        private System.Windows.Forms.Button newAcctBtn;
        private System.Windows.Forms.RadioButton currentRbtn;
        private System.Windows.Forms.RadioButton savingsRbtn;
    }
}