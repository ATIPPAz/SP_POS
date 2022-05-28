using SP_POS.Classes;
using SP_POS.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_POS.Pages.PosPage
{
    public partial class Pos : UserControl
    {
        DataTable dt = new DataTable();
        List<Product> OrderCart = new List<Product>();
        List<Body> OrderlistDetail = new List<Body>();
        public Pos()
        {
            InitializeComponent(); getProduct(); setcardt();
        }
        void getProduct()
        {
            Sql sql = new Sql();
            var data = sql.Select("Select ProdDetailID,ProdCost,BrandID as ProdBrand,ProdStatusID  as ProdStatus,TypeID as ProdType,Annotation,ProdID,ProdName,ProdPrice,ProdDest,ProdQty,ProdImage from [dbo].[ProductData] where ProdStatusID ='PS001'");
            dt = data;
        }
        void setcardt()
        {
            int x = 50, y = 50;
            foreach (DataRow item in dt.Rows)
            {
                ProductCard pc = new ProductCard();
                pc.Location = new Point(x, y);
                pc.Size = new Size(200, 75);
                pc.setcard(item["ProdImage"].ToString(), item["ProdName"].ToString(), item["ProdQty"].ToString(), item["ProdPrice"].ToString(), item["ProdID"].ToString(), item["ProdCost"].ToString()) ;
                pc.AddCart.Click += new EventHandler((object sender, EventArgs e) => {
                    var find = OrderCart.Find(pd => pd.ProdID == pc.productcardData.ProdID);
                    if (find == null)
                    {
                        OrderCart.Add(pc.productcardData);
                        var body =new Body();
                        body.setProduct(pc.productcardData);
                        body.createBtn();
                        body.Dock = DockStyle.Top;
                        OrderPanel.Controls.Add(body);
                        OrderlistDetail.Add(body);
                    };
                });
                Product.Controls.Add(pc);
                x += 250;
                if (x >= 800)
                {
                    x = 50;
                    y += 100;
                }
            }
        }
    }
}
