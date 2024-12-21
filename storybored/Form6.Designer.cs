namespace storybored
{
    partial class rgstech
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCpassword = new System.Windows.Forms.TextBox();
            this.textBoxnumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnreg = new System.Windows.Forms.Button();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WELCOME = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.textBoxname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxemail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxCpassword);
            this.groupBox1.Controls.Add(this.textBoxnumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnreg);
            this.groupBox1.Controls.Add(this.textBoxusername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxpassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(3, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 327);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter account information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxname
            // 
            this.textBoxname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxname.Location = new System.Drawing.Point(134, 19);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(100, 20);
            this.textBoxname.TabIndex = 16;
            this.textBoxname.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "name";
            // 
            // textBoxemail
            // 
            this.textBoxemail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxemail.Location = new System.Drawing.Point(134, 70);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(100, 20);
            this.textBoxemail.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "email";
            // 
            // textBoxCpassword
            // 
            this.textBoxCpassword.Location = new System.Drawing.Point(134, 203);
            this.textBoxCpassword.MaxLength = 8;
            this.textBoxCpassword.Name = "textBoxCpassword";
            this.textBoxCpassword.PasswordChar = '*';
            this.textBoxCpassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxCpassword.TabIndex = 13;
            // 
            // textBoxnumber
            // 
            this.textBoxnumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxnumber.Location = new System.Drawing.Point(134, 258);
            this.textBoxnumber.MaxLength = 10;
            this.textBoxnumber.Name = "textBoxnumber";
            this.textBoxnumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxnumber.TabIndex = 12;
            this.textBoxnumber.TextChanged += new System.EventHandler(this.textBoxnumber_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Confirm Password";
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(134, 298);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(75, 23);
            this.btnreg.TabIndex = 8;
            this.btnreg.Text = "DONE";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxusername
            // 
            this.textBoxusername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxusername.Location = new System.Drawing.Point(134, 109);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(100, 20);
            this.textBoxusername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxpassword.Location = new System.Drawing.Point(134, 155);
            this.textBoxpassword.MaxLength = 8;
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.PasswordChar = '*';
            this.textBoxpassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxpassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contact number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "username";
            // 
            // WELCOME
            // 
            this.WELCOME.AutoSize = true;
            this.WELCOME.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WELCOME.ForeColor = System.Drawing.Color.Snow;
            this.WELCOME.Location = new System.Drawing.Point(4, 32);
            this.WELCOME.Name = "WELCOME";
            this.WELCOME.Size = new System.Drawing.Size(482, 45);
            this.WELCOME.TabIndex = 11;
            this.WELCOME.Text = "Register New Technician";
            // 
            // rgstech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WELCOME);
            this.Controls.Add(this.groupBox1);
            this.Name = "rgstech";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.rgstech_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxnumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCpassword;
        private System.Windows.Forms.Label WELCOME;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Label label5;
    }
}