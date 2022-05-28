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
        public Product product = new Product();
        public Button AddBtn;
        public Button RemoveBtn;
        
        public Body()
        {
            InitializeComponent();
            
        }
        public Product getProduct()
        {
          return product;
        }
        public void setText() { Qty.Text = product.ProdQty; }

        public void setProduct(Product pd,int qty)
        {
            product.ProdID = pd.ProdID.ToString();
            product.ProdPrice = pd.ProdPrice.ToString();
            product.ProdQty = pd.ProdQty.ToString();
            product.ProdName = pd.ProdName.ToString();
            product.ProdQty = qty.ToString();
            ProdName.Text = product.ProdName;
            Price.Text = product.ProdPrice;
            Qty.Text = product.ProdQty;
        }
        public void setProduct(Product pd)
        {
            product.ProdID = pd.ProdID.ToString();
            product.ProdPrice = pd.ProdPrice.ToString();
            product.ProdQty = pd.ProdQty.ToString();
            product.ProdName = pd.ProdName.ToString();
            ProdName.Text = product.ProdName;
            Price.Text = product.ProdPrice;
            Qty.Text = product.ProdQty;
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
            AddBtn = new Button();
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
            AddBtn.BackColor = System.Drawing.Color.YellowGreen;
            AddBtn.FlatAppearance.BorderSize = 0;
           AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           AddBtn.ForeColor = System.Drawing.Color.White;
           
           AddBtn.Name = "AddBtns";
           AddBtn.Size = new System.Drawing.Size(20, 20);
           AddBtn.TabIndex = 1;
           AddBtn.Text = "+";
           AddBtn.UseVisualStyleBackColor = false;
            AddBtn.BringToFront();
            AddBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            AddPanel.Controls.Add(AddBtn);
        }
    }
}
