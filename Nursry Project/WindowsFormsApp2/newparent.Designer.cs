namespace WindowsFormsApp2
{
    partial class newparent
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtparentphone = new System.Windows.Forms.Label();
            this.txtparentage = new System.Windows.Forms.Label();
            this.txtparentname = new System.Windows.Forms.TextBox();
            this.txtparentemail = new System.Windows.Forms.TextBox();
            this.txtparentpassword = new System.Windows.Forms.TextBox();
            this.parentphone = new System.Windows.Forms.TextBox();
            this.parentage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(207, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(360, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parent Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parent Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parent Password";
            // 
            // txtparentphone
            // 
            this.txtparentphone.AutoSize = true;
            this.txtparentphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtparentphone.Location = new System.Drawing.Point(40, 252);
            this.txtparentphone.Name = "txtparentphone";
            this.txtparentphone.Size = new System.Drawing.Size(122, 20);
            this.txtparentphone.TabIndex = 5;
            this.txtparentphone.Text = "Parent Phone";
            // 
            // txtparentage
            // 
            this.txtparentage.AutoSize = true;
            this.txtparentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtparentage.Location = new System.Drawing.Point(40, 319);
            this.txtparentage.Name = "txtparentage";
            this.txtparentage.Size = new System.Drawing.Size(102, 20);
            this.txtparentage.TabIndex = 6;
            this.txtparentage.Text = "Parent Age";
            // 
            // txtparentname
            // 
            this.txtparentname.Location = new System.Drawing.Point(233, 61);
            this.txtparentname.Name = "txtparentname";
            this.txtparentname.Size = new System.Drawing.Size(187, 22);
            this.txtparentname.TabIndex = 7;
            // 
            // txtparentemail
            // 
            this.txtparentemail.Location = new System.Drawing.Point(233, 121);
            this.txtparentemail.Name = "txtparentemail";
            this.txtparentemail.Size = new System.Drawing.Size(187, 22);
            this.txtparentemail.TabIndex = 8;
            // 
            // txtparentpassword
            // 
            this.txtparentpassword.Location = new System.Drawing.Point(233, 186);
            this.txtparentpassword.Name = "txtparentpassword";
            this.txtparentpassword.Size = new System.Drawing.Size(187, 22);
            this.txtparentpassword.TabIndex = 9;
            // 
            // parentphone
            // 
            this.parentphone.Location = new System.Drawing.Point(233, 252);
            this.parentphone.Name = "parentphone";
            this.parentphone.Size = new System.Drawing.Size(187, 22);
            this.parentphone.TabIndex = 10;
            // 
            // parentage
            // 
            this.parentage.Location = new System.Drawing.Point(233, 317);
            this.parentage.Name = "parentage";
            this.parentage.Size = new System.Drawing.Size(187, 22);
            this.parentage.TabIndex = 11;
            // 
            // newparent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 501);
            this.Controls.Add(this.parentage);
            this.Controls.Add(this.parentphone);
            this.Controls.Add(this.txtparentpassword);
            this.Controls.Add(this.txtparentemail);
            this.Controls.Add(this.txtparentname);
            this.Controls.Add(this.txtparentage);
            this.Controls.Add(this.txtparentphone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "newparent";
            this.Text = "newparent";
            this.Load += new System.EventHandler(this.newparent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtparentphone;
        private System.Windows.Forms.Label txtparentage;
        private System.Windows.Forms.TextBox txtparentname;
        private System.Windows.Forms.TextBox txtparentemail;
        private System.Windows.Forms.TextBox txtparentpassword;
        private System.Windows.Forms.TextBox parentphone;
        private System.Windows.Forms.TextBox parentage;
    }
}