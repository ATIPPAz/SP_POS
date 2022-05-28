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

namespace SP_POS.Pages.PosPage.Payment_Method
{
    public partial class CreditPayment : UserControl
    {
        List<Body> order;
        public CreditPayment()
        {
            InitializeComponent();
        }
        int total = 0;
        string Cid, username, CAddress;
        public void getdata(List<Body> order ,int total, string id,string name, string add)
        {
            this.order = order;
            this.total= total;
            Cid = id;
            username = name;
            CAddress = add;
        }
        private void Payment_Click(object sender, EventArgs e)
        {
            Sql select = new Sql();
            var res = select.Select($"select BankMoney FROM [dbo].[BankMoney] where BankNumber = '{Credittxt.Text}'");
            if(res.Rows.Count == 0)
            {
                Toast.Error("ไม่พบบัญชี");
            }
            else
            {
                foreach (DataRow item in res.Rows)
                {
                    int money = Convert.ToInt32(item["BankMoney"].ToString());
                    
                    if (money < total)
                    {
                        Toast.Error("ไม่สามารถชำระได้ยอดเงินไม่พอ");
                    }
                    else
                    { 
                        money -= total;
                        select.Update($"UPDATE[dbo].[BankMoney] SET[BankMoney] = {money} WHERE BankNumber = '{Credittxt.Text}'");
                        //create order
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
                            invoke.print(data, "Bill Recipt", username, CAddress, total, "", "", "Cradit");
                            //create order
                        }
                        catch (Exception)
                        {
                            Toast.Error("เกิดข้อผิดพลาด");
                        }
                    }
                }
            }
        }
    }
}
