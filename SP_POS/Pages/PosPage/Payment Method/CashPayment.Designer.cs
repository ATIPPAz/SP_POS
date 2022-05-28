namespace SP_POS.Pages.PosPage.Payment_Method
{
    partial class CashPayment
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
            this.totaldisplay = new System.Windows.Forms.Label();
            this.moneytxt = new System.Windows.Forms.TextBox();
            this.invoke = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.changelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // totaldisplay
            // 
            this.totaldisplay.AutoSize = true;
            this.totaldisplay.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaldisplay.Location = new System.Drawing.Point(227, 38);
            this.totaldisplay.Name = "totaldisplay";
            this.totaldisplay.Size = new System.Drawing.Size(59, 29);
            this.totaldisplay.TabIndex = 0;
            this.totaldisplay.Text = "1000";
            // 
            // moneytxt
            // 
            this.moneytxt.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneytxt.Location = new System.Drawing.Point(232, 106);
            this.moneytxt.Name = "moneytxt";
            this.moneytxt.Size = new System.Drawing.Size(116, 36);
            this.moneytxt.TabIndex = 1;
            // 
            // invoke
            // 
            this.invoke.BackColor = System.Drawing.Color.DodgerBlue;
            this.invoke.Enabled = false;
            this.invoke.FlatAppearance.BorderSize = 0;
            this.invoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invoke.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoke.ForeColor = System.Drawing.Color.White;
            this.invoke.Location = new System.Drawing.Point(514, 445);
            this.invoke.Name = "invoke";
            this.invoke.Size = new System.Drawing.Size(161, 40);
            this.invoke.TabIndex = 3;
            this.invoke.Text = "สั่งสินค้า";
            this.invoke.UseVisualStyleBackColor = false;
            this.invoke.Click += new System.EventHandler(this.invoke_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "ของทั้งหมดราคา :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "เงินที่รับมา :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "ทอนเงิน :";
            // 
            // changelbl
            // 
            this.changelbl.AutoSize = true;
            this.changelbl.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changelbl.Location = new System.Drawing.Point(240, 192);
            this.changelbl.Name = "changelbl";
            this.changelbl.Size = new System.Drawing.Size(46, 29);
            this.changelbl.TabIndex = 0;
            this.changelbl.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "บาท";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(354, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "บาท";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(354, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "บาท";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.moneytxt);
            this.panel1.Controls.Add(this.totaldisplay);
            this.panel1.Controls.Add(this.changelbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(103, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 266);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Prompt", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 72);
            this.label5.TabIndex = 5;
            this.label5.Text = "ชำระแบบเงินสด";
            // 
            // Payment
            // 
            this.Payment.BackColor = System.Drawing.Color.ForestGreen;
            this.Payment.FlatAppearance.BorderSize = 0;
            this.Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Payment.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.ForeColor = System.Drawing.Color.White;
            this.Payment.Location = new System.Drawing.Point(335, 445);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(161, 40);
            this.Payment.TabIndex = 3;
            this.Payment.Text = "ชำระเงิน";
            this.Payment.UseVisualStyleBackColor = false;
            this.Payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // CashPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.invoke);
            this.Name = "CashPayment";
            this.Size = new System.Drawing.Size(692, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totaldisplay;
        private System.Windows.Forms.TextBox moneytxt;
        private System.Windows.Forms.Button invoke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label changelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Payment;
    }
}
