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
            
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Route.BackToPos(Route.index.DisplayPanel);
        }

        private void Findbtn_Click(object sender, EventArgs e)
        {
            Sql select = new Sql();
            var cust = select.Select($"select CustFName,CustLName,CustAddress,CustID FROM [dbo].[CustomerData] where CustUsername = '{Usertxt.Text}'");
            Console.WriteLine(cust);
            if(cust.Rows.Count !=0)
            {

            }
            else
            {
                Toast.Error("ไม่พบ user");
            }
        }
    }
}
