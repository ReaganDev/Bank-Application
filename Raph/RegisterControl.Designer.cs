
namespace Raph
{
    partial class RegisterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.amountTxtBox = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.savingRbtn = new System.Windows.Forms.RadioButton();
            this.currentRBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // amountTxtBox
            // 
            this.amountTxtBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.amountTxtBox.Location = new System.Drawing.Point(84, 220);
            this.amountTxtBox.Name = "amountTxtBox";
            this.amountTxtBox.PlaceholderText = "enter Amount";
            this.amountTxtBox.Size = new System.Drawing.Size(288, 45);
            this.amountTxtBox.TabIndex = 0;
            this.amountTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountTxtBox.TextChanged += new System.EventHandler(this.amountTxtBox_TextChanged);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.RegisterBtn.FlatAppearance.BorderSize = 0;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Location = new System.Drawing.Point(86, 294);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(288, 71);
            this.RegisterBtn.TabIndex = 1;
            this.RegisterBtn.Text = "REGISTER";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // savingRbtn
            // 
            this.savingRbtn.AutoSize = true;
            this.savingRbtn.FlatAppearance.BorderSize = 0;
            this.savingRbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.savingRbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.savingRbtn.Location = new System.Drawing.Point(110, 108);
            this.savingRbtn.Name = "savingRbtn";
            this.savingRbtn.Size = new System.Drawing.Size(205, 36);
            this.savingRbtn.TabIndex = 2;
            this.savingRbtn.TabStop = true;
            this.savingRbtn.Text = "Savings Account";
            this.savingRbtn.UseVisualStyleBackColor = true;
            this.savingRbtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // currentRBtn
            // 
            this.currentRBtn.AutoSize = true;
            this.currentRBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.currentRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(112)))));
            this.currentRBtn.Location = new System.Drawing.Point(110, 150);
            this.currentRBtn.Name = "currentRBtn";
            this.currentRBtn.Size = new System.Drawing.Size(207, 36);
            this.currentRBtn.TabIndex = 3;
            this.currentRBtn.TabStop = true;
            this.currentRBtn.Text = "Current Account";
            this.currentRBtn.UseVisualStyleBackColor = true;
            this.currentRBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.currentRBtn);
            this.Controls.Add(this.savingRbtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.amountTxtBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(413, 125);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(475, 444);
            this.Load += new System.EventHandler(this.RegisterControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountTxtBox;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.RadioButton savingRbtn;
        private System.Windows.Forms.RadioButton currentRBtn;
    }
}
