namespace rentalcarsystem
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvat = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radbtnsedan = new System.Windows.Forms.RadioButton();
            this.radbtnsuv = new System.Windows.Forms.RadioButton();
            this.radbtnmpv = new System.Windows.Forms.RadioButton();
            this.chksunroof = new System.Windows.Forms.CheckBox();
            this.chksound = new System.Windows.Forms.CheckBox();
            this.chkleather = new System.Windows.Forms.CheckBox();
            this.lstreceipt = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Days";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "price";
            // 
            // txtvat
            // 
            this.txtvat.Location = new System.Drawing.Point(93, 324);
            this.txtvat.Name = "txtvat";
            this.txtvat.Size = new System.Drawing.Size(100, 20);
            this.txtvat.TabIndex = 7;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(93, 82);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 8;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(93, 134);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 20);
            this.txtphone.TabIndex = 9;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(93, 181);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 20);
            this.txtaddress.TabIndex = 10;
            // 
            // txtdays
            // 
            this.txtdays.Location = new System.Drawing.Point(93, 231);
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(100, 20);
            this.txtdays.TabIndex = 11;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(93, 278);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 12;
            this.txtprice.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radbtnsedan);
            this.groupBox1.Controls.Add(this.radbtnsuv);
            this.groupBox1.Controls.Add(this.radbtnmpv);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(268, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 126);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(224, -84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 125);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkleather);
            this.groupBox3.Controls.Add(this.chksunroof);
            this.groupBox3.Controls.Add(this.chksound);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(268, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 135);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extras";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(224, -84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(110, 125);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(274, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 199);
            this.listBox1.TabIndex = 1;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(220, 344);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 39);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radbtnsedan
            // 
            this.radbtnsedan.AutoSize = true;
            this.radbtnsedan.Location = new System.Drawing.Point(16, 36);
            this.radbtnsedan.Name = "radbtnsedan";
            this.radbtnsedan.Size = new System.Drawing.Size(122, 17);
            this.radbtnsedan.TabIndex = 16;
            this.radbtnsedan.TabStop = true;
            this.radbtnsedan.Text = "SEDAN(R1000/day)";
            this.radbtnsedan.UseVisualStyleBackColor = true;
            // 
            // radbtnsuv
            // 
            this.radbtnsuv.AutoSize = true;
            this.radbtnsuv.Location = new System.Drawing.Point(16, 67);
            this.radbtnsuv.Name = "radbtnsuv";
            this.radbtnsuv.Size = new System.Drawing.Size(107, 17);
            this.radbtnsuv.TabIndex = 17;
            this.radbtnsuv.TabStop = true;
            this.radbtnsuv.Text = "SUV(R2000/day)";
            this.radbtnsuv.UseVisualStyleBackColor = true;
            // 
            // radbtnmpv
            // 
            this.radbtnmpv.AutoSize = true;
            this.radbtnmpv.Location = new System.Drawing.Point(16, 102);
            this.radbtnmpv.Name = "radbtnmpv";
            this.radbtnmpv.Size = new System.Drawing.Size(108, 17);
            this.radbtnmpv.TabIndex = 18;
            this.radbtnmpv.TabStop = true;
            this.radbtnmpv.Text = "MPV(R4000/day)";
            this.radbtnmpv.UseVisualStyleBackColor = true;
            // 
            // chksunroof
            // 
            this.chksunroof.AutoSize = true;
            this.chksunroof.Location = new System.Drawing.Point(21, 19);
            this.chksunroof.Name = "chksunroof";
            this.chksunroof.Size = new System.Drawing.Size(101, 17);
            this.chksunroof.TabIndex = 16;
            this.chksunroof.Text = "Sunroof(R1000)";
            this.chksunroof.UseVisualStyleBackColor = true;
            // 
            // chksound
            // 
            this.chksound.AutoSize = true;
            this.chksound.Location = new System.Drawing.Point(21, 57);
            this.chksound.Name = "chksound";
            this.chksound.Size = new System.Drawing.Size(132, 17);
            this.chksound.TabIndex = 17;
            this.chksound.Text = "Sound System(R1500)";
            this.chksound.UseVisualStyleBackColor = true;
            // 
            // chkleather
            // 
            this.chkleather.AutoSize = true;
            this.chkleather.Location = new System.Drawing.Point(21, 94);
            this.chkleather.Name = "chkleather";
            this.chkleather.Size = new System.Drawing.Size(135, 17);
            this.chkleather.TabIndex = 18;
            this.chkleather.Text = "Leather Interior(R3000)";
            this.chkleather.UseVisualStyleBackColor = true;
            this.chkleather.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // lstreceipt
            // 
            this.lstreceipt.FormattingEnabled = true;
            this.lstreceipt.Location = new System.Drawing.Point(492, 0);
            this.lstreceipt.Name = "lstreceipt";
            this.lstreceipt.Size = new System.Drawing.Size(204, 264);
            this.lstreceipt.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstreceipt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtdays);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtvat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CarRentalCalculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtvat;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radbtnsedan;
        private System.Windows.Forms.RadioButton radbtnsuv;
        private System.Windows.Forms.RadioButton radbtnmpv;
        private System.Windows.Forms.CheckBox chksunroof;
        private System.Windows.Forms.CheckBox chksound;
        private System.Windows.Forms.CheckBox chkleather;
        private System.Windows.Forms.ListBox lstreceipt;
    }
}

