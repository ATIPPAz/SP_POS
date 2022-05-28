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
        public Payment()
        {
            InitializeComponent();
            GetHeader();
            DateLabel.Text =  DateTime.Today.ToString("dd-MM-yyyy");
        }

        private void GetHeader()
        {
            Header header = new Header();
            
        }
        public void GetData(List<Body> data,int Totalpay)
        {
            data.ForEach(x =>
            {
                var body = new Body();
                body.setProduct(x.getProduct());
                body.Dock = DockStyle.Top;
                OrderPanel.Controls.Add(body);
            });
            Totallbl.Text = Totalpay.ToString()+"  บาทถ้วน";    
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Route.BackToPos(Route.index.DisplayPanel);
        }
        string CID, CFname, CLastName, Caddress;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
            Route.OpenCashPage(PaymentPanel);

            }
            else if(comboBox1.SelectedIndex == 1)
            {
            Route.OpenCreditPage(PaymentPanel);


            }
            else if (comboBox1.SelectedIndex == 2)
            {
            Route.OpenTransferPage(PaymentPanel);

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
                    CFname = item["CustFName"].ToString();
                    CLastName = item["CustLName"].ToString();
                    Caddress = item["CustAddress"].ToString();
                    addresslabel.Text = item["CustAddress"].ToString();
                    Namelabel.Text = item["CustPrefix"].ToString() + " " + item["CustFName"].ToString() + " " + item["CustLName"].ToString();
                }
            }
            else
            {
                cust = select.Select($"select CustFName,CustLName,CustAddress,CustID FROM [dbo].[CustomerData] where CustPhone = '{Usertxt.Text}'");
                if (cust.Rows.Count != 0)
                {
                    foreach (DataRow item in cust.Rows)
                    {
                        CID = item["CustID"].ToString();
                        CFname = item["CustFName"].ToString();
                        CLastName = item["CustLName"].ToString();
                        Caddress = item["CustAddress"].ToString();
                        addresslabel.Text = item["CustAddress"].ToString();
                        Namelabel.Text = item["CustPrefix"].ToString() + " " + item["CustFName"].ToString() + " " + item["CustLName"].ToString();
                    }
                }
                else
                {
                    Toast.Error("ไม่พบ user");
                    CID = "";
                    CFname = "";
                    CLastName = "";
                    Caddress = "";
                    addresslabel.Text = "";
                    Namelabel.Text = "";
                }
            }
        }
    }
}
