namespace SP_POS.Controls
{
    partial class ProductCard
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
            this.Price = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.Label();
            this.PName = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.AddCart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.AddCart);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.Qty);
            this.panel1.Controls.Add(this.PName);
            this.panel1.Location = new System.Drawing.Point(89, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 69);
            this.panel1.TabIndex = 1;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(3, 50);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(35, 13);
            this.Price.TabIndex = 0;
            this.Price.Text = "label1";
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Location = new System.Drawing.Point(3, 31);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(35, 13);
            this.Qty.TabIndex = 0;
            this.Qty.Text = "label1";
            // 
            // PName
            // 
            this.PName.AutoSize = true;
            this.PName.Location = new System.Drawing.Point(3, 9);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(35, 13);
            this.PName.TabIndex = 0;
            this.PName.Text = "label1";
            // 
            // image
            // 
            this.image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image.Location = new System.Drawing.Point(3, 3);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(80, 69);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // AddCart
            // 
            this.AddCart.BackColor = System.Drawing.Color.YellowGreen;
            this.AddCart.FlatAppearance.BorderSize = 0;
            this.AddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCart.ForeColor = System.Drawing.Color.White;
            this.AddCart.Location = new System.Drawing.Point(67, 47);
            this.AddCart.Name = "AddCart";
            this.AddCart.Size = new System.Drawing.Size(38, 19);
            this.AddCart.TabIndex = 1;
            this.AddCart.Text = "เพิ่ม";
            this.AddCart.UseVisualStyleBackColor = false;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.image);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(200, 75);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.Label PName;
        public System.Windows.Forms.Button AddCart;
    }
}
