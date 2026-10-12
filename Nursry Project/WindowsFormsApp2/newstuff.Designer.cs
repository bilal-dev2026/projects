namespace WindowsFormsApp2
{
    partial class newstuff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newstuff));
            this.label1 = new System.Windows.Forms.Label();
            this.txtnameadd = new System.Windows.Forms.TextBox();
            this.txtemailadd = new System.Windows.Forms.TextBox();
            this.txtpasswordadd = new System.Windows.Forms.TextBox();
            this.txtphoneadd = new System.Windows.Forms.TextBox();
            this.txtageadd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stuff Name";
            // 
            // txtnameadd
            // 
            this.txtnameadd.Location = new System.Drawing.Point(229, 85);
            this.txtnameadd.Name = "txtnameadd";
            this.txtnameadd.Size = new System.Drawing.Size(173, 22);
            this.txtnameadd.TabIndex = 1;
            // 
            // txtemailadd
            // 
            this.txtemailadd.Location = new System.Drawing.Point(229, 149);
            this.txtemailadd.Name = "txtemailadd";
            this.txtemailadd.Size = new System.Drawing.Size(173, 22);
            this.txtemailadd.TabIndex = 2;
            // 
            // txtpasswordadd
            // 
            this.txtpasswordadd.Location = new System.Drawing.Point(229, 211);
            this.txtpasswordadd.Name = "txtpasswordadd";
            this.txtpasswordadd.Size = new System.Drawing.Size(173, 22);
            this.txtpasswordadd.TabIndex = 3;
            // 
            // txtphoneadd
            // 
            this.txtphoneadd.Location = new System.Drawing.Point(229, 268);
            this.txtphoneadd.Name = "txtphoneadd";
            this.txtphoneadd.Size = new System.Drawing.Size(173, 22);
            this.txtphoneadd.TabIndex = 4;
            // 
            // txtageadd
            // 
            this.txtageadd.Location = new System.Drawing.Point(229, 326);
            this.txtageadd.Name = "txtageadd";
            this.txtageadd.Size = new System.Drawing.Size(173, 22);
            this.txtageadd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stuff Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stuff Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stuff Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stuff Age";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(229, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newstuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtageadd);
            this.Controls.Add(this.txtphoneadd);
            this.Controls.Add(this.txtpasswordadd);
            this.Controls.Add(this.txtemailadd);
            this.Controls.Add(this.txtnameadd);
            this.Controls.Add(this.label1);
            this.Name = "newstuff";
            this.Text = "newstuff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnameadd;
        private System.Windows.Forms.TextBox txtemailadd;
        private System.Windows.Forms.TextBox txtpasswordadd;
        private System.Windows.Forms.TextBox txtphoneadd;
        private System.Windows.Forms.TextBox txtageadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}