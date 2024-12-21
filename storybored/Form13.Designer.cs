
namespace storybored
{
    partial class Form13
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
            this.WELCOME = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbconfpass = new System.Windows.Forms.Label();
            this.textBoxconfpassword = new System.Windows.Forms.TextBox();
            this.textBoxnewpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnreg = new System.Windows.Forms.Button();
            this.textBoxcurrpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WELCOME
            // 
            this.WELCOME.AutoSize = true;
            this.WELCOME.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WELCOME.ForeColor = System.Drawing.Color.Snow;
            this.WELCOME.Location = new System.Drawing.Point(25, 24);
            this.WELCOME.Name = "WELCOME";
            this.WELCOME.Size = new System.Drawing.Size(341, 45);
            this.WELCOME.TabIndex = 15;
            this.WELCOME.Text = "Update password";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.lbconfpass);
            this.groupBox1.Controls.Add(this.textBoxconfpassword);
            this.groupBox1.Controls.Add(this.textBoxnewpassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnreg);
            this.groupBox1.Controls.Add(this.textBoxcurrpassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(24, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 327);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // lbconfpass
            // 
            this.lbconfpass.AutoSize = true;
            this.lbconfpass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbconfpass.Location = new System.Drawing.Point(6, 152);
            this.lbconfpass.Name = "lbconfpass";
            this.lbconfpass.Size = new System.Drawing.Size(122, 18);
            this.lbconfpass.TabIndex = 17;
            this.lbconfpass.Text = "confirm Password";
            // 
            // textBoxconfpassword
            // 
            this.textBoxconfpassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxconfpassword.Location = new System.Drawing.Point(134, 153);
            this.textBoxconfpassword.Name = "textBoxconfpassword";
            this.textBoxconfpassword.Size = new System.Drawing.Size(159, 20);
            this.textBoxconfpassword.TabIndex = 16;
            // 
            // textBoxnewpassword
            // 
            this.textBoxnewpassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxnewpassword.Location = new System.Drawing.Point(134, 98);
            this.textBoxnewpassword.Name = "textBoxnewpassword";
            this.textBoxnewpassword.Size = new System.Drawing.Size(159, 20);
            this.textBoxnewpassword.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "New Password";
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(134, 298);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(75, 23);
            this.btnreg.TabIndex = 8;
            this.btnreg.Text = "DONE";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // textBoxcurrpassword
            // 
            this.textBoxcurrpassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxcurrpassword.Location = new System.Drawing.Point(134, 28);
            this.textBoxcurrpassword.Name = "textBoxcurrpassword";
            this.textBoxcurrpassword.Size = new System.Drawing.Size(159, 20);
            this.textBoxcurrpassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WELCOME);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form13";
            this.Text = "Form13";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WELCOME;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxnewpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.TextBox textBoxcurrpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbconfpass;
        private System.Windows.Forms.TextBox textBoxconfpassword;
    }
}