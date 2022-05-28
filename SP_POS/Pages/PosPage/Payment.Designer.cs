namespace SP_POS.Pages.PosPage
{
    partial class Payment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.PaymentPanel = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.Findbtn = new System.Windows.Forms.Button();
            this.PaymentMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.addresslabel = new System.Windows.Forms.Label();
            this.header1 = new SP_POS.Controls.Header();
            this.label4 = new System.Windows.Forms.Label();
            this.Totallbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.PaymentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.HeaderPanel);
            this.panel1.Controls.Add(this.OrderPanel);
            this.panel1.Location = new System.Drawing.Point(18, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 500);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.Totallbl);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(16, 452);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 40);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.Add(this.header1);
            this.panel6.Location = new System.Drawing.Point(16, 88);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 40);
            this.panel6.TabIndex = 0;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.LightGray;
            this.HeaderPanel.Controls.Add(this.addresslabel);
            this.HeaderPanel.Controls.Add(this.Namelabel);
            this.HeaderPanel.Controls.Add(this.DateLabel);
            this.HeaderPanel.Controls.Add(this.label3);
            this.HeaderPanel.Controls.Add(this.label2);
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Location = new System.Drawing.Point(16, 15);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(400, 67);
            this.HeaderPanel.TabIndex = 0;
            // 
            // OrderPanel
            // 
            this.OrderPanel.BackColor = System.Drawing.Color.LightGray;
            this.OrderPanel.Location = new System.Drawing.Point(16, 132);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(400, 314);
            this.OrderPanel.TabIndex = 0;
            // 
            // PaymentPanel
            // 
            this.PaymentPanel.BackColor = System.Drawing.Color.White;
            this.PaymentPanel.Controls.Add(this.StatusLbl);
            this.PaymentPanel.Location = new System.Drawing.Point(492, 107);
            this.PaymentPanel.Name = "PaymentPanel";
            this.PaymentPanel.Size = new System.Drawing.Size(692, 500);
            this.PaymentPanel.TabIndex = 0;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Firebrick;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(18, 19);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(88, 34);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Usertxt
            // 
            this.Usertxt.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usertxt.Location = new System.Drawing.Point(166, 69);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(178, 36);
            this.Usertxt.TabIndex = 2;
            // 
            // Findbtn
            // 
            this.Findbtn.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Findbtn.Location = new System.Drawing.Point(362, 71);
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(86, 34);
            this.Findbtn.TabIndex = 3;
            this.Findbtn.Text = "ค้นหา";
            this.Findbtn.UseVisualStyleBackColor = true;
            this.Findbtn.Click += new System.EventHandler(this.Findbtn_Click);
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.Enabled = false;
            this.PaymentMethod.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethod.FormattingEnabled = true;
            this.PaymentMethod.Items.AddRange(new object[] {
            "เงินสด",
            "เครดิต",
            "โอนเงิน"});
            this.PaymentMethod.Location = new System.Drawing.Point(685, 64);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(225, 37);
            this.PaymentMethod.TabIndex = 4;
            this.PaymentMethod.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "วันที่ : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "ผู้รับ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "ที่อยู่ :";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(46, 8);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 19);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "____";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(46, 24);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(33, 19);
            this.Namelabel.TabIndex = 1;
            this.Namelabel.Text = "____";
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslabel.Location = new System.Drawing.Point(46, 44);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(33, 19);
            this.addresslabel.TabIndex = 1;
            this.addresslabel.Text = "____";
            // 
            // header1
            // 
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(400, 40);
            this.header1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "รวมเป็น :";
            // 
            // Totallbl
            // 
            this.Totallbl.AutoSize = true;
            this.Totallbl.Location = new System.Drawing.Point(316, 13);
            this.Totallbl.Name = "Totallbl";
            this.Totallbl.Size = new System.Drawing.Size(35, 13);
            this.Totallbl.TabIndex = 1;
            this.Totallbl.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "ข้อมูลเมมเบอร์ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(496, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "เลือกวิธีการชำระเงิน :";
            // 
            // StatusLbl
            // 
            this.StatusLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLbl.Font = new System.Drawing.Font("Prompt", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.StatusLbl.Location = new System.Drawing.Point(0, 0);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(692, 500);
            this.StatusLbl.TabIndex = 0;
            this.StatusLbl.Text = "กรุณาค้นหา member ก่อนเลือกวิธีการชำระเงิน";
            this.StatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PaymentMethod);
            this.Controls.Add(this.Findbtn);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.PaymentPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(1200, 620);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.PaymentPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.Panel PaymentPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.Button Findbtn;
        private System.Windows.Forms.ComboBox PaymentMethod;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controls.Header header1;
        private System.Windows.Forms.Label Totallbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label StatusLbl;
    }
}
