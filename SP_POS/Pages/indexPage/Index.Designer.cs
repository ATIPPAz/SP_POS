namespace SP_POS
{
    partial class PosIndex
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.LinePanel = new System.Windows.Forms.Panel();
            this.ManuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PosBtn = new System.Windows.Forms.Label();
            this.Memberbtn = new System.Windows.Forms.Label();
            this.ProductBtn = new System.Windows.Forms.Label();
            this.ReportBtn = new System.Windows.Forms.Label();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.Exitbtn = new System.Windows.Forms.PictureBox();
            this.MinimunBtn = new System.Windows.Forms.PictureBox();
            this.HeaderPanel.SuspendLayout();
            this.ManuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exitbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimunBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.HeaderPanel.Controls.Add(this.Exitbtn);
            this.HeaderPanel.Controls.Add(this.MinimunBtn);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1200, 45);
            this.HeaderPanel.TabIndex = 0;
            // 
            // LinePanel
            // 
            this.LinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LinePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LinePanel.Location = new System.Drawing.Point(0, 45);
            this.LinePanel.Name = "LinePanel";
            this.LinePanel.Size = new System.Drawing.Size(1200, 1);
            this.LinePanel.TabIndex = 1;
            // 
            // ManuPanel
            // 
            this.ManuPanel.ColumnCount = 4;
            this.ManuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ManuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ManuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ManuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ManuPanel.Controls.Add(this.PosBtn, 0, 0);
            this.ManuPanel.Controls.Add(this.Memberbtn, 1, 0);
            this.ManuPanel.Controls.Add(this.ProductBtn, 2, 0);
            this.ManuPanel.Controls.Add(this.ReportBtn, 3, 0);
            this.ManuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManuPanel.Location = new System.Drawing.Point(0, 46);
            this.ManuPanel.Name = "ManuPanel";
            this.ManuPanel.RowCount = 1;
            this.ManuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ManuPanel.Size = new System.Drawing.Size(1200, 34);
            this.ManuPanel.TabIndex = 1;
            // 
            // PosBtn
            // 
            this.PosBtn.AutoSize = true;
            this.PosBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.PosBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PosBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(118)))), ((int)(((byte)(242)))));
            this.PosBtn.Location = new System.Drawing.Point(3, 0);
            this.PosBtn.Name = "PosBtn";
            this.PosBtn.Size = new System.Drawing.Size(294, 34);
            this.PosBtn.TabIndex = 0;
            this.PosBtn.Text = "POS";
            this.PosBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PosBtn.Click += new System.EventHandler(this.PosBtn_Click);
            this.PosBtn.Enter += new System.EventHandler(this.PosBtn_Enter);
            // 
            // Memberbtn
            // 
            this.Memberbtn.AutoSize = true;
            this.Memberbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.Memberbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Memberbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Memberbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Memberbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memberbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(118)))), ((int)(((byte)(242)))));
            this.Memberbtn.Location = new System.Drawing.Point(303, 0);
            this.Memberbtn.Name = "Memberbtn";
            this.Memberbtn.Size = new System.Drawing.Size(294, 34);
            this.Memberbtn.TabIndex = 1;
            this.Memberbtn.Text = "Members";
            this.Memberbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Memberbtn.Click += new System.EventHandler(this.MemberBtn_Click);
            // 
            // ProductBtn
            // 
            this.ProductBtn.AutoSize = true;
            this.ProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.ProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(118)))), ((int)(((byte)(242)))));
            this.ProductBtn.Location = new System.Drawing.Point(603, 0);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Size = new System.Drawing.Size(294, 34);
            this.ProductBtn.TabIndex = 2;
            this.ProductBtn.Text = "Products";
            this.ProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // ReportBtn
            // 
            this.ReportBtn.AutoSize = true;
            this.ReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.ReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(118)))), ((int)(((byte)(242)))));
            this.ReportBtn.Location = new System.Drawing.Point(903, 0);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(294, 34);
            this.ReportBtn.TabIndex = 3;
            this.ReportBtn.Text = "Report";
            this.ReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.DisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayPanel.Location = new System.Drawing.Point(0, 80);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(1200, 620);
            this.DisplayPanel.TabIndex = 2;
            // 
            // Exitbtn
            // 
            this.Exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exitbtn.Image = global::SP_POS.Properties.Resources.close;
            this.Exitbtn.Location = new System.Drawing.Point(1165, 7);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(29, 26);
            this.Exitbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exitbtn.TabIndex = 0;
            this.Exitbtn.TabStop = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // MinimunBtn
            // 
            this.MinimunBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimunBtn.Image = global::SP_POS.Properties.Resources.minus;
            this.MinimunBtn.Location = new System.Drawing.Point(1123, 15);
            this.MinimunBtn.Name = "MinimunBtn";
            this.MinimunBtn.Size = new System.Drawing.Size(36, 19);
            this.MinimunBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimunBtn.TabIndex = 0;
            this.MinimunBtn.TabStop = false;
            this.MinimunBtn.Click += new System.EventHandler(this.MinimunBtn_Click);
            // 
            // PosIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.ManuPanel);
            this.Controls.Add(this.LinePanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PosIndex";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PosIndex_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.ManuPanel.ResumeLayout(false);
            this.ManuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exitbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimunBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox MinimunBtn;
        private System.Windows.Forms.PictureBox Exitbtn;
        private System.Windows.Forms.TableLayoutPanel ManuPanel;
        private System.Windows.Forms.Label PosBtn;
        private System.Windows.Forms.Label Memberbtn;
        private System.Windows.Forms.Label ProductBtn;
        private System.Windows.Forms.Label ReportBtn;
        private System.Windows.Forms.Panel LinePanel;
        private System.Windows.Forms.Panel DisplayPanel;
    }
}

