using SP_POS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_POS.Controls
{
    public partial class Body : UserControl
    {
        Product product = new Product();
        public Button AddBtns;
        public Button RemoveBtn;
        
        public Body()
        {
            InitializeComponent();
            
        }
        public void setProduct(Product pd,int qty)
        {
            product = pd;
            product.ProdQty = qty.ToString();
            ProdName.Text = product.ProdName;
            Price.Text = product.ProdPrice;
            Qty.Text = (qty).ToString();
        }
        public void setQty(string qty)
        {
            Qty.Text = qty;
            product.ProdQty = qty;
        }
        public string getQty()
        {
            return product.ProdQty;
        }
        public  void createBtn()
        {
            AddBtns = new Button();
            RemoveBtn = new Button();
            RemoveBtn.BackColor = System.Drawing.Color.Firebrick;
            RemoveBtn.FlatAppearance.BorderSize = 0;
            RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RemoveBtn.ForeColor = System.Drawing.Color.White;
            RemoveBtn.Location = new System.Drawing.Point(0, 4);
            RemoveBtn.Name = "RemoveBtns";
            RemoveBtn.Size = new System.Drawing.Size(20, 20);
            RemoveBtn.TabIndex = 1;
            RemoveBtn.Text = "-";
            RemoveBtn.UseVisualStyleBackColor = false;
            RemoveBtn.BringToFront();
            RemoveBtn.Dock = System.Windows.Forms.DockStyle.Fill;

            RemovePanel.Controls.Add(RemoveBtn);
            // 
            // AddBtns
            // 
            AddBtns.BackColor = System.Drawing.Color.YellowGreen;
            AddBtns.FlatAppearance.BorderSize = 0;
           AddBtns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           AddBtns.ForeColor = System.Drawing.Color.White;
           
           AddBtns.Name = "AddBtns";
           AddBtns.Size = new System.Drawing.Size(20, 20);
           AddBtns.TabIndex = 1;
           AddBtns.Text = "+";
           AddBtns.UseVisualStyleBackColor = false;
            AddBtns.BringToFront();
            AddBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            AddPanel.Controls.Add(AddBtns);
        }
    }
}
