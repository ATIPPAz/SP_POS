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
        List<Body> OrderlistDetail = new List<Body>();
        List<ProductCard> productCard = new List<ProductCard>();
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
                productCard.Add(pc);

                pc.AddCart.Click += new EventHandler((object sender, EventArgs e) => {
                    int Orderidx = OrderlistDetail.FindIndex(data => data.getProduct().ProdID == pc.productcardData.ProdID);
                    int productidx = productCard.FindIndex(data => data.getProduct().ProdID == pc.productcardData.ProdID);
                    if (Orderidx == -1)
                    {
                        var body =new Body();
                        body.setProduct(pc.productcardData,1);
                        body.createBtn();
                        body.Dock = DockStyle.Top;
                        body.AddBtn.Click += new EventHandler((object s, EventArgs ex) =>
                        {
                            string oid = body.getProduct().ProdID;
                            int OrID = OrderlistDetail.FindIndex(data => data.getProduct().ProdID == oid);
                            int pID = productCard.FindIndex(data => data.getProduct().ProdID == oid);
                            if(Convert.ToInt32(productCard[pID].productcardData.ProdQty) > 0)
                            {
                                OrderlistDetail[OrID].setQty((Convert.ToInt32(OrderlistDetail[OrID].getQty()) + 1).ToString());
                                productCard[pID].productcardData.ProdQty = (Convert.ToInt32(productCard[pID].productcardData.ProdQty) - 1).ToString();
                                productCard[productidx].setText();
                                calTotal();
                            }

                        });
                        body.RemoveBtn.Click += new EventHandler((object s, EventArgs ex) =>
                        {
                            string oid = body.getProduct().ProdID;
                            int OrID = OrderlistDetail.FindIndex(data => data.getProduct().ProdID == oid);
                            int pID = productCard.FindIndex(data => data.getProduct().ProdID == oid);
                            if (Convert.ToInt32(OrderlistDetail[OrID].getProduct().ProdQty) > 1)
                            {
                                OrderlistDetail[OrID].setQty((Convert.ToInt32(OrderlistDetail[OrID].getQty()) - 1).ToString());
                                productCard[pID].productcardData.ProdQty = (Convert.ToInt32(productCard[pID].productcardData.ProdQty) + 1).ToString();
                                productCard[productidx].setText();
                                calTotal();
                            }
                            else if (Convert.ToInt32(OrderlistDetail[OrID].getProduct().ProdQty)  ==1)
                            {
                                OrderPanel.Controls.Remove(OrderlistDetail[OrID]);
                                OrderlistDetail[OrID].Hide();
                                OrderlistDetail[OrID].Dispose();
                                OrderlistDetail.RemoveAt(OrID);
                                productCard[pID].productcardData.ProdQty = (Convert.ToInt32(productCard[pID].productcardData.ProdQty) + 1).ToString();
                                productCard[productidx].setText();
                                calTotal();
                            }

                        });
                        OrderPanel.Controls.Add(body);
                        OrderlistDetail.Add(body);
                       
                        //productCard[productidx].setQty();
                        productCard[productidx].productcardData.ProdQty = (Convert.ToInt32(productCard[productidx].productcardData.ProdQty) - 1).ToString();
                        productCard[productidx].setText();

                    }
                    else
                    {
                       
                        if (Convert.ToInt32(productCard[productidx].productcardData.ProdQty) >0)
                        {
                            OrderlistDetail[Orderidx].setQty((Convert.ToInt32(OrderlistDetail[Orderidx].getQty()) + 1).ToString());
                            productCard[productidx].productcardData.ProdQty = (Convert.ToInt32(productCard[productidx].productcardData.ProdQty) - 1).ToString();
                            productCard[productidx].setText();
                        }
                    }
                    calTotal();

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
        void calTotal()
        {
            int total = 0;
            OrderlistDetail.ForEach(x => { total+= Convert.ToInt32(x.getProduct().ProdPrice) * Convert.ToInt32(x.getProduct().ProdQty); });
            Total.Text = total.ToString()+" บาท";
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            OrderlistDetail.Clear();
            productCard.Clear();
            OrderPanel.Controls.Clear();
            Product.Controls.Clear();
            getProduct(); setcardt();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
