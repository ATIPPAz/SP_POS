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
    public partial class Payment : UserControl
    {
        int total = 0;
        public Payment()
        {
            InitializeComponent();
            DateLabel.Text =  DateTime.Today.ToString("dd-MM-yyyy");
        }

        private void GetHeader()
        {
            
        }
        List<Body> orderlist;
        public void GetData(List<Body> data, int Totalpay)
        {
            data.ForEach(x =>
            {
                var body = new Body();
                body.setProduct(x.getProduct());
                body.Dock = DockStyle.Top;
                OrderPanel.Controls.Add(body);
            });
            Totallbl.Text = Totalpay.ToString()+"  บาทถ้วน";
            total = Totalpay;
            orderlist = data;
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Route.BackToPos(Route.index.DisplayPanel);
        }
        string CID = "", username = "", Caddress = "";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PaymentMethod.SelectedIndex == 0)
            {
            Route.OpenCashPage(PaymentPanel, total, orderlist);
                Route.CashPaymentpage.GetCust(username,CID,Caddress);
                StatusLbl.SendToBack();

            }
            else if(PaymentMethod.SelectedIndex == 1)
            {
            Route.OpenCreditPage(PaymentPanel);
                StatusLbl.SendToBack();


            }
            else if (PaymentMethod.SelectedIndex == 2)
            {
            Route.OpenTransferPage(PaymentPanel);
                StatusLbl.SendToBack();

            }
        }

        private void Findbtn_Click(object sender, EventArgs e)
        {
            Sql select = new Sql();
            var cust = select.Select($"select CustPrefix,CustFName,CustLName,CustAddress,CustID FROM [dbo].[CustomerData] where CustUsername = '{Usertxt.Text}'");
            Console.WriteLine(cust);
            if(cust.Rows.Count !=0)
            {
                foreach (DataRow item in cust.Rows)
                {
                    CID = item["CustID"].ToString();
                    Caddress = item["CustAddress"].ToString();
                    addresslabel.Text = item["CustAddress"].ToString();
                    Namelabel.Text = item["CustPrefix"].ToString() + " " + item["CustFName"].ToString() + " " + item["CustLName"].ToString();
                    username = Namelabel.Text;
                }
                PaymentMethod.Enabled = true;
                StatusLbl.Text = "สามารถเลือกวิธีการชำระได้";
                StatusLbl.BringToFront();
            }
            else
            {
                cust = select.Select($"select CustFName,CustLName,CustAddress,CustID FROM [dbo].[CustomerData] where CustPhone = '{Usertxt.Text}'");
                if (cust.Rows.Count != 0)
                {
                    foreach (DataRow item in cust.Rows)
                    {
                        CID = item["CustID"].ToString();
                        Caddress = item["CustAddress"].ToString();
                        addresslabel.Text = item["CustAddress"].ToString();
                        Namelabel.Text = item["CustPrefix"].ToString() + " " + item["CustFName"].ToString() + " " + item["CustLName"].ToString();
                        username = Namelabel.Text;
                    }
                    PaymentMethod.Enabled = true;
                    StatusLbl.Text = "สามารถเลือกวิธีการชำระได้";
                    StatusLbl.BringToFront();

                }
                else
                {
                    Toast.Error("ไม่พบ user");
                    CID = "";
                    username = "";
                    Caddress = "";
                    addresslabel.Text = "";
                    Namelabel.Text = "";
                    PaymentMethod.Enabled = false;
                    StatusLbl.Text = "กรุณาค้นหา member ก่อนเลือกวิธีการชำระเงิน";
                    StatusLbl.BringToFront();
                }
            }
        }
    }
}
