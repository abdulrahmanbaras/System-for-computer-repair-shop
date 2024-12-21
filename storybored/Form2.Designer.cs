namespace storybored
{
    partial class Registercusfrm
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
            this.lblreg = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxyear = new System.Windows.Forms.ComboBox();
            this.comboBoxdd = new System.Windows.Forms.ComboBox();
            this.comboBoxmonth = new System.Windows.Forms.ComboBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.listBoxsertyp = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxserv = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblreg
            // 
            this.lblreg.AutoSize = true;
            this.lblreg.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreg.ForeColor = System.Drawing.Color.Snow;
            this.lblreg.Location = new System.Drawing.Point(153, 22);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(460, 45);
            this.lblreg.TabIndex = 1;
            this.lblreg.Text = "Register New Customer";
            this.lblreg.Click += new System.EventHandler(this.WELCOME_Click);
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(132, 73);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(100, 20);
            this.textBoxname.TabIndex = 2;
            // 
            // textBoxnum
            // 
            this.textBoxnum.Location = new System.Drawing.Point(134, 112);
            this.textBoxnum.MaxLength = 10;
            this.textBoxnum.Name = "textBoxnum";
            this.textBoxnum.Size = new System.Drawing.Size(100, 20);
            this.textBoxnum.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Custmer name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contact number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Service";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "DONE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxyear);
            this.groupBox1.Controls.Add(this.comboBoxdd);
            this.groupBox1.Controls.Add(this.comboBoxmonth);
            this.groupBox1.Controls.Add(this.textBoxusername);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxemail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblprice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxpassword);
            this.groupBox1.Controls.Add(this.listBoxsertyp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listBoxserv);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxnum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 368);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter customer information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(302, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = " date:";
            // 
            // comboBoxyear
            // 
            this.comboBoxyear.FormattingEnabled = true;
            this.comboBoxyear.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.comboBoxyear.Location = new System.Drawing.Point(529, 39);
            this.comboBoxyear.Name = "comboBoxyear";
            this.comboBoxyear.Size = new System.Drawing.Size(73, 21);
            this.comboBoxyear.TabIndex = 25;
            this.comboBoxyear.Text = "year";
            // 
            // comboBoxdd
            // 
            this.comboBoxdd.FormattingEnabled = true;
            this.comboBoxdd.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxdd.Location = new System.Drawing.Point(355, 39);
            this.comboBoxdd.Name = "comboBoxdd";
            this.comboBoxdd.Size = new System.Drawing.Size(41, 21);
            this.comboBoxdd.TabIndex = 24;
            this.comboBoxdd.Text = "dd";
            // 
            // comboBoxmonth
            // 
            this.comboBoxmonth.FormattingEnabled = true;
            this.comboBoxmonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.comboBoxmonth.Location = new System.Drawing.Point(402, 39);
            this.comboBoxmonth.Name = "comboBoxmonth";
            this.comboBoxmonth.Size = new System.Drawing.Size(121, 21);
            this.comboBoxmonth.TabIndex = 23;
            this.comboBoxmonth.Text = "month";
            // 
            // textBoxusername
            // 
            this.textBoxusername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxusername.Location = new System.Drawing.Point(132, 35);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(100, 20);
            this.textBoxusername.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "username";
            // 
            // textBoxemail
            // 
            this.textBoxemail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxemail.Location = new System.Drawing.Point(134, 193);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(100, 20);
            this.textBoxemail.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "email";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(75, 336);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(0, 18);
            this.lblprice.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password";
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxpassword.Location = new System.Drawing.Point(134, 155);
            this.textBoxpassword.MaxLength = 8;
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.PasswordChar = '*';
            this.textBoxpassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxpassword.TabIndex = 14;
            // 
            // listBoxsertyp
            // 
            this.listBoxsertyp.FormattingEnabled = true;
            this.listBoxsertyp.Items.AddRange(new object[] {
            "Normal",
            "Urgent"});
            this.listBoxsertyp.Location = new System.Drawing.Point(134, 299);
            this.listBoxsertyp.Name = "listBoxsertyp";
            this.listBoxsertyp.Size = new System.Drawing.Size(65, 17);
            this.listBoxsertyp.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Service type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listBoxserv
            // 
            this.listBoxserv.FormattingEnabled = true;
            this.listBoxserv.Items.AddRange(new object[] {
            "Remove virus, malware or spyware",
            "Troubleshot and fix computer running slow",
            "Laptop screen replacement",
            "Laptop keyboard replacement",
            "Laptop battery replacement",
            "Operating System Format and Installation",
            "Data backup and recovery",
            "Internet connectivity issues"});
            this.listBoxserv.Location = new System.Drawing.Point(104, 229);
            this.listBoxserv.Name = "listBoxserv";
            this.listBoxserv.Size = new System.Drawing.Size(240, 43);
            this.listBoxserv.TabIndex = 10;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Registercusfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblreg);
            this.Name = "Registercusfrm";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Registercusfrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblreg;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxserv;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxsertyp;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxyear;
        private System.Windows.Forms.ComboBox comboBoxdd;
        private System.Windows.Forms.ComboBox comboBoxmonth;
    }
}