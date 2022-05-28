namespace SP_POS.Controls
{
    partial class Body
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
            this.ProdName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.RemovePanel = new System.Windows.Forms.Panel();
            this.Qty = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Price = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProdName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 30);
            this.panel1.TabIndex = 0;
            // 
            // ProdName
            // 
            this.ProdName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdName.Location = new System.Drawing.Point(0, 0);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(150, 30);
            this.ProdName.TabIndex = 0;
            this.ProdName.Text = "Name";
            this.ProdName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AddPanel);
            this.panel2.Controls.Add(this.RemovePanel);
            this.panel2.Controls.Add(this.Qty);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 30);
            this.panel2.TabIndex = 1;
            // 
            // AddPanel
            // 
            this.AddPanel.BackColor = System.Drawing.SystemColors.Control;
            this.AddPanel.Location = new System.Drawing.Point(114, 3);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(20, 20);
            this.AddPanel.TabIndex = 1;
            // 
            // RemovePanel
            // 
            this.RemovePanel.Location = new System.Drawing.Point(6, 3);
            this.RemovePanel.Name = "RemovePanel";
            this.RemovePanel.Size = new System.Drawing.Size(20, 20);
            this.RemovePanel.TabIndex = 1;
            // 
            // Qty
            // 
            this.Qty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Qty.Location = new System.Drawing.Point(0, 0);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(140, 30);
            this.Qty.TabIndex = 0;
            this.Qty.Text = "label2";
            this.Qty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Price);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(290, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 30);
            this.panel3.TabIndex = 2;
            // 
            // Price
            // 
            this.Price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Price.Location = new System.Drawing.Point(0, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(110, 30);
            this.Price.TabIndex = 0;
            this.Price.Text = "label3";
            this.Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Body
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Body";
            this.Size = new System.Drawing.Size(400, 30);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ProdName;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.Label Price;

        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Panel RemovePanel;
    }
}
