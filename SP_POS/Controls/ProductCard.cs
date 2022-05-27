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
        public ProductCard()
        {
            InitializeComponent();
        }
        public void setcard(string img,string name,string qty,string cost)
        {
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.LoadAsync(img);
            label1.Text = name;
            label2.Text = qty;
            label3.Text = cost;
        }
    }
}
