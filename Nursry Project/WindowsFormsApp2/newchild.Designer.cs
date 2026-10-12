namespace WindowsFormsApp2
{
    partial class newchild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newchild));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtchildname = new System.Windows.Forms.TextBox();
            this.txtchildbirthday = new System.Windows.Forms.TextBox();
            this.txtchildparent = new System.Windows.Forms.TextBox();
            this.txtchildroom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtparentname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtparentemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtparentpassword = new System.Windows.Forms.TextBox();
            this.txtparentphone = new System.Windows.Forms.Label();
            this.parentphone = new System.Windows.Forms.TextBox();
            this.txtparentage = new System.Windows.Forms.Label();
            this.parentage = new System.Windows.Forms.TextBox();
            this.txtfeedback = new System.Windows.Forms.TextBox();
            this.txtextratime = new System.Windows.Forms.TextBox();
            this.txtpayperiod = new System.Windows.Forms.TextBox();
            this.txtpaymethod = new System.Windows.Forms.TextBox();
            this.txtbus = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Child Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Child Age";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Child Parent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(441, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Child Room";
            // 
            // txtchildname
            // 
            this.txtchildname.Location = new System.Drawing.Point(592, 33);
            this.txtchildname.Name = "txtchildname";
            this.txtchildname.Size = new System.Drawing.Size(182, 22);
            this.txtchildname.TabIndex = 6;
            this.txtchildname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtchildbirthday
            // 
            this.txtchildbirthday.Location = new System.Drawing.Point(592, 72);
            this.txtchildbirthday.Name = "txtchildbirthday";
            this.txtchildbirthday.Size = new System.Drawing.Size(182, 22);
            this.txtchildbirthday.TabIndex = 7;
            // 
            // txtchildparent
            // 
            this.txtchildparent.Location = new System.Drawing.Point(592, 113);
            this.txtchildparent.Name = "txtchildparent";
            this.txtchildparent.Size = new System.Drawing.Size(182, 22);
            this.txtchildparent.TabIndex = 8;
            this.txtchildparent.TextChanged += new System.EventHandler(this.txtchildparent_TextChanged);
            // 
            // txtchildroom
            // 
            this.txtchildroom.Location = new System.Drawing.Point(592, 156);
            this.txtchildroom.Name = "txtchildroom";
            this.txtchildroom.Size = new System.Drawing.Size(182, 22);
            this.txtchildroom.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(171, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Parent Name";
            // 
            // txtparentname
            // 
            this.txtparentname.Location = new System.Drawing.Point(207, 35);
            this.txtparentname.Name = "txtparentname";
            this.txtparentname.Size = new System.Drawing.Size(187, 22);
            this.txtparentname.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Parent Email";
            // 
            // txtparentemail
            // 
            this.txtparentemail.Location = new System.Drawing.Point(207, 88);
            this.txtparentemail.Name = "txtparentemail";
            this.txtparentemail.Size = new System.Drawing.Size(187, 22);
            this.txtparentemail.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Parent Password";
            // 
            // txtparentpassword
            // 
            this.txtparentpassword.Location = new System.Drawing.Point(207, 142);
            this.txtparentpassword.Name = "txtparentpassword";
            this.txtparentpassword.Size = new System.Drawing.Size(187, 22);
            this.txtparentpassword.TabIndex = 16;
            // 
            // txtparentphone
            // 
            this.txtparentphone.AutoSize = true;
            this.txtparentphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtparentphone.Location = new System.Drawing.Point(25, 190);
            this.txtparentphone.Name = "txtparentphone";
            this.txtparentphone.Size = new System.Drawing.Size(122, 20);
            this.txtparentphone.TabIndex = 17;
            this.txtparentphone.Text = "Parent Phone";
            // 
            // parentphone
            // 
            this.parentphone.Location = new System.Drawing.Point(207, 188);
            this.parentphone.Name = "parentphone";
            this.parentphone.Size = new System.Drawing.Size(187, 22);
            this.parentphone.TabIndex = 18;
            // 
            // txtparentage
            // 
            this.txtparentage.AutoSize = true;
            this.txtparentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtparentage.Location = new System.Drawing.Point(25, 239);
            this.txtparentage.Name = "txtparentage";
            this.txtparentage.Size = new System.Drawing.Size(102, 20);
            this.txtparentage.TabIndex = 19;
            this.txtparentage.Text = "Parent Age";
            // 
            // parentage
            // 
            this.parentage.Location = new System.Drawing.Point(207, 237);
            this.parentage.Name = "parentage";
            this.parentage.Size = new System.Drawing.Size(187, 22);
            this.parentage.TabIndex = 20;
            // 
            // txtfeedback
            // 
            this.txtfeedback.Location = new System.Drawing.Point(592, 363);
            this.txtfeedback.Name = "txtfeedback";
            this.txtfeedback.Size = new System.Drawing.Size(182, 22);
            this.txtfeedback.TabIndex = 58;
            // 
            // txtextratime
            // 
            this.txtextratime.Location = new System.Drawing.Point(592, 325);
            this.txtextratime.Name = "txtextratime";
            this.txtextratime.Size = new System.Drawing.Size(182, 22);
            this.txtextratime.TabIndex = 57;
            // 
            // txtpayperiod
            // 
            this.txtpayperiod.Location = new System.Drawing.Point(592, 286);
            this.txtpayperiod.Name = "txtpayperiod";
            this.txtpayperiod.Size = new System.Drawing.Size(182, 22);
            this.txtpayperiod.TabIndex = 56;
            // 
            // txtpaymethod
            // 
            this.txtpaymethod.Location = new System.Drawing.Point(592, 246);
            this.txtpaymethod.Name = "txtpaymethod";
            this.txtpaymethod.Size = new System.Drawing.Size(182, 22);
            this.txtpaymethod.TabIndex = 55;
            // 
            // txtbus
            // 
            this.txtbus.Location = new System.Drawing.Point(592, 201);
            this.txtbus.Name = "txtbus";
            this.txtbus.Size = new System.Drawing.Size(182, 22);
            this.txtbus.TabIndex = 54;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(441, 203);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(114, 20);
            this.label24.TabIndex = 53;
            this.label24.Text = "Nursery Bus";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(425, 248);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(148, 20);
            this.label23.TabIndex = 52;
            this.label23.Text = "Payment Method";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(425, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Payment Period";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(425, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Add Extra Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(423, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "Parent Feedback";
            // 
            // newchild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 392);
            this.Controls.Add(this.txtfeedback);
            this.Controls.Add(this.txtextratime);
            this.Controls.Add(this.txtpayperiod);
            this.Controls.Add(this.txtpaymethod);
            this.Controls.Add(this.txtbus);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.parentage);
            this.Controls.Add(this.txtparentage);
            this.Controls.Add(this.parentphone);
            this.Controls.Add(this.txtparentphone);
            this.Controls.Add(this.txtparentpassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtparentemail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtparentname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtchildroom);
            this.Controls.Add(this.txtchildparent);
            this.Controls.Add(this.txtchildbirthday);
            this.Controls.Add(this.txtchildname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "newchild";
            this.Text = "newchild";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtchildname;
        private System.Windows.Forms.TextBox txtchildbirthday;
        private System.Windows.Forms.TextBox txtchildparent;
        private System.Windows.Forms.TextBox txtchildroom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtparentname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtparentemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtparentpassword;
        private System.Windows.Forms.Label txtparentphone;
        private System.Windows.Forms.TextBox parentphone;
        private System.Windows.Forms.Label txtparentage;
        private System.Windows.Forms.TextBox parentage;
        private System.Windows.Forms.TextBox txtfeedback;
        private System.Windows.Forms.TextBox txtextratime;
        private System.Windows.Forms.TextBox txtpayperiod;
        private System.Windows.Forms.TextBox txtpaymethod;
        private System.Windows.Forms.TextBox txtbus;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}