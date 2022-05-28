namespace SP_POS.Pages.PosPage.Payment_Method
{
    partial class CreditPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.Credittxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Prompt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cradit Number :";
            // 
            // Credittxt
            // 
            this.Credittxt.Font = new System.Drawing.Font("Prompt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credittxt.Location = new System.Drawing.Point(292, 217);
            this.Credittxt.Name = "Credittxt";
            this.Credittxt.Size = new System.Drawing.Size(344, 48);
            this.Credittxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Prompt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "ชำระแบบบัตรเครดิต ";
            // 
            // Payment
            // 
            this.Payment.BackColor = System.Drawing.Color.Green;
            this.Payment.FlatAppearance.BorderSize = 0;
            this.Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Payment.Font = new System.Drawing.Font("Prompt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.ForeColor = System.Drawing.Color.White;
            this.Payment.Location = new System.Drawing.Point(566, 449);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(112, 39);
            this.Payment.TabIndex = 2;
            this.Payment.Text = "สั่งซื้อ";
            this.Payment.UseVisualStyleBackColor = false;
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // CreditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.Credittxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreditPayment";
            this.Size = new System.Drawing.Size(692, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Credittxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Payment;
    }
}
