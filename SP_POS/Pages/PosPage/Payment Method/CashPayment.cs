using SP_POS.Classes;
using SP_POS.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_POS.Pages.PosPage.Payment_Method
{
    public partial class CashPayment : UserControl
    {
        List<Body> order;
        public CashPayment()
        {
            InitializeComponent();
        }
        int total = 0;
        public void getTotal(int total, List<Body> order)
        {
            this.total = total;
            totaldisplay.Text = total.ToString();
            changelbl.Text = "0";
            this.order = order;
        }
        string username = "", Cid = "", add = "";
        string change = "";
        string rec = "";
        public void GetCust(string username,string Cid , string add)
        {
            this.username = username;
            this.Cid = Cid;
            this.add = add;
        }
        private void payment_Click(object sender, EventArgs e)
        {
            try
            {
                int money = Convert.ToInt32(moneytxt.Text);
                if (total > money)
                {
                    Toast.Error("ยอดเงินไม่เพียงพอ กรุณาจ่ายใหม่");
                    invoke.Enabled = false;

                }
                else if(money > total)
                {
                    changelbl.Text = (money - total).ToString();
                    change = changelbl.Text;
                    rec = money.ToString();
                    invoke.Enabled = true;
                    //print invoke and add order
                }
            }
            catch (Exception )
            {
                Toast.Error("กรุณากรอกจำนวนเงินให้ถูกต้อง");
                invoke.Enabled = false;
                moneytxt.Clear();
                moneytxt.Focus();
            }
        }

        private void invoke_Click(object sender, EventArgs e)
        {
            try
            {
                invoke invoke = new invoke();
                DataTable data = new DataTable();
                List<Product> products = new List<Product>();
                order.ForEach(x => products.Add(x.product));
                ConvertToDataTable ct = new ConvertToDataTable();
                data = ct.ToDataTable(products);
                data.Columns.Remove("ProdDetailID");
                data.Columns.Remove("ProdCost");
                data.Columns.Remove("ProdBrand");
                data.Columns.Remove("ProdStatus");
                data.Columns.Remove("ProdType");
                data.Columns.Remove("ProdDest");
                data.Columns.Remove("ProdImage");
                invoke.print(data, "Bill Recipt", username, add, total, rec, change, "cashier");
                //create order
            }
            catch (Exception)
            {
                Toast.Error("เกิดข้อผิดพลาด");
            }
            
        }
    }
}
