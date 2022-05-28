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
    public partial class ProductCard : UserControl
    {
        public Product productcardData = new Product();
        public ProductCard()
        {
            InitializeComponent();
        }
        public string getQty()
        {
            return productcardData.ProdQty;
        }
        public Product getProduct()
        {
            return productcardData;
        }
        public void setQty(string qty)
        {
            productcardData.ProdQty = qty;
            Qty.Text = productcardData.ProdQty;
        }
        public void setcard(string img,string name,string qty,string price,string id,string cost)
        {
            image.LoadAsync(img);
            image.SizeMode = PictureBoxSizeMode.Zoom;
            Qty.Text = qty;
            PName.Text = name;
            Price.Text = price;
            productcardData.ProdCost = cost;
            productcardData.ProdPrice= price;
            productcardData.ProdName = name;
            productcardData.ProdQty = qty;
            productcardData.ProdID = id;
        }
    }
}
