namespace storybored
{
    partial class Form4
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
            this.lblupdate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxnewusername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnreg = new System.Windows.Forms.Button();
            this.textBoxcurrusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblupdate
            // 
            this.lblupdate.AutoSize = true;
            this.lblupdate.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupdate.ForeColor = System.Drawing.Color.Snow;
            this.lblupdate.Location = new System.Drawing.Point(13, 27);
            this.lblupdate.Name = "lblupdate";
            this.lblupdate.Size = new System.Drawing.Size(358, 45);
            this.lblupdate.TabIndex = 13;
            this.lblupdate.Text = " Update username";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.textBoxnewusername);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnreg);
            this.groupBox1.Controls.Add(this.textBoxcurrusername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 327);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxnewusername
            // 
            this.textBoxnewusername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxnewusername.Location = new System.Drawing.Point(134, 98);
            this.textBoxnewusername.Name = "textBoxnewusername";
            this.textBoxnewusername.Size = new System.Drawing.Size(159, 20);
            this.textBoxnewusername.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "new username";
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(134, 281);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(116, 23);
            this.btnreg.TabIndex = 8;
            this.btnreg.Text = "DONE";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // textBoxcurrusername
            // 
            this.textBoxcurrusername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxcurrusername.Location = new System.Drawing.Point(134, 28);
            this.textBoxcurrusername.Name = "textBoxcurrusername";
            this.textBoxcurrusername.Size = new System.Drawing.Size(159, 20);
            this.textBoxcurrusername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "current username";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblupdate);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Edite";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblupdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxnewusername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.TextBox textBoxcurrusername;
        private System.Windows.Forms.Label label1;
    }
}