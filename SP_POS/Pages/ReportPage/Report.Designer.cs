namespace SP_POS.Pages.ReportPage
{
    partial class Report
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
            this.dgvAllorder = new System.Windows.Forms.DataGridView();
            this.dgvTotalOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Allorder = new System.Windows.Forms.Button();
            this.TotalOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Alllorderlbl = new System.Windows.Forms.Label();
            this.TotalOrderlbl = new System.Windows.Forms.Label();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdCost2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllorder
            // 
            this.dgvAllorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllorder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.CreateDate,
            this.OrderDetailID,
            this.ProdID,
            this.ProdQty,
            this.ProdPrice});
            this.dgvAllorder.Location = new System.Drawing.Point(16, 126);
            this.dgvAllorder.Name = "dgvAllorder";
            this.dgvAllorder.Size = new System.Drawing.Size(547, 456);
            this.dgvAllorder.TabIndex = 0;
            // 
            // dgvTotalOrder
            // 
            this.dgvTotalOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID2,
            this.CreateDate2,
            this.ProdID2,
            this.ProdQty2,
            this.ProdPrice2,
            this.ProdCost2,
            this.realPrice});
            this.dgvTotalOrder.Location = new System.Drawing.Point(569, 126);
            this.dgvTotalOrder.Name = "dgvTotalOrder";
            this.dgvTotalOrder.Size = new System.Drawing.Size(600, 456);
            this.dgvTotalOrder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ยอดขายทั้งหมด";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(566, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ยอดขายแบบกำไร";
            // 
            // Allorder
            // 
            this.Allorder.Location = new System.Drawing.Point(474, 85);
            this.Allorder.Name = "Allorder";
            this.Allorder.Size = new System.Drawing.Size(75, 23);
            this.Allorder.TabIndex = 2;
            this.Allorder.Text = "download";
            this.Allorder.UseVisualStyleBackColor = true;
            // 
            // TotalOrder
            // 
            this.TotalOrder.Location = new System.Drawing.Point(1094, 85);
            this.TotalOrder.Name = "TotalOrder";
            this.TotalOrder.Size = new System.Drawing.Size(75, 23);
            this.TotalOrder.TabIndex = 2;
            this.TotalOrder.Text = "download";
            this.TotalOrder.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 595);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "บาท";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1134, 595);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "บาท";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 595);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "ยอดขายรวม";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(990, 595);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "กำไรรวม";
            // 
            // Alllorderlbl
            // 
            this.Alllorderlbl.AutoSize = true;
            this.Alllorderlbl.Location = new System.Drawing.Point(458, 595);
            this.Alllorderlbl.Name = "Alllorderlbl";
            this.Alllorderlbl.Size = new System.Drawing.Size(25, 13);
            this.Alllorderlbl.TabIndex = 3;
            this.Alllorderlbl.Text = "100";
            // 
            // TotalOrderlbl
            // 
            this.TotalOrderlbl.AutoSize = true;
            this.TotalOrderlbl.Location = new System.Drawing.Point(1068, 595);
            this.TotalOrderlbl.Name = "TotalOrderlbl";
            this.TotalOrderlbl.Size = new System.Drawing.Size(25, 13);
            this.TotalOrderlbl.TabIndex = 3;
            this.TotalOrderlbl.Text = "100";
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.Name = "OrderID";
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "CreateDate";
            this.CreateDate.Name = "CreateDate";
            // 
            // OrderDetailID
            // 
            this.OrderDetailID.DataPropertyName = "OrderDetailID";
            this.OrderDetailID.HeaderText = "OrderDetailID";
            this.OrderDetailID.Name = "OrderDetailID";
            // 
            // ProdID
            // 
            this.ProdID.DataPropertyName = "ProdID";
            this.ProdID.HeaderText = "ProdID";
            this.ProdID.Name = "ProdID";
            // 
            // ProdQty
            // 
            this.ProdQty.DataPropertyName = "ProdQty";
            this.ProdQty.HeaderText = "ProdQty";
            this.ProdQty.Name = "ProdQty";
            // 
            // ProdPrice
            // 
            this.ProdPrice.DataPropertyName = "ProdPrice";
            this.ProdPrice.HeaderText = "ProdPrice";
            this.ProdPrice.Name = "ProdPrice";
            // 
            // OrderID2
            // 
            this.OrderID2.DataPropertyName = "OrderID";
            this.OrderID2.HeaderText = "OrderID";
            this.OrderID2.Name = "OrderID2";
            // 
            // CreateDate2
            // 
            this.CreateDate2.DataPropertyName = "CreateDate";
            this.CreateDate2.HeaderText = "CreateDate";
            this.CreateDate2.Name = "CreateDate2";
            // 
            // ProdID2
            // 
            this.ProdID2.DataPropertyName = "ProdID";
            this.ProdID2.HeaderText = "ProdID";
            this.ProdID2.Name = "ProdID2";
            // 
            // ProdQty2
            // 
            this.ProdQty2.DataPropertyName = "ProdQty";
            this.ProdQty2.HeaderText = "ProdQty";
            this.ProdQty2.Name = "ProdQty2";
            // 
            // ProdPrice2
            // 
            this.ProdPrice2.DataPropertyName = "ProdPrice";
            this.ProdPrice2.HeaderText = "ProdPrice";
            this.ProdPrice2.Name = "ProdPrice2";
            // 
            // ProdCost2
            // 
            this.ProdCost2.DataPropertyName = "ProdCost";
            this.ProdCost2.HeaderText = "ProdCost";
            this.ProdCost2.Name = "ProdCost2";
            // 
            // realPrice
            // 
            this.realPrice.DataPropertyName = "realPrice";
            this.realPrice.HeaderText = "realPrice";
            this.realPrice.Name = "realPrice";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalOrderlbl);
            this.Controls.Add(this.Alllorderlbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalOrder);
            this.Controls.Add(this.Allorder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTotalOrder);
            this.Controls.Add(this.dgvAllorder);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(1200, 620);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllorder;
        private System.Windows.Forms.DataGridView dgvTotalOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Allorder;
        private System.Windows.Forms.Button TotalOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Alllorderlbl;
        private System.Windows.Forms.Label TotalOrderlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdCost2;
        private System.Windows.Forms.DataGridViewTextBoxColumn realPrice;
    }
}
