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

namespace SP_POS.Pages.ReportPage
{
    public partial class Report : UserControl
    {
        Sql sq = new Sql();
        DataTable OrderAll = new DataTable();
        public Report()
        {
            InitializeComponent();
            getAllOrder();
        }
        void getAllOrder()
        {
            var data = sq.Select("SELECT  [OrderID],[CreateDate],[OrderDetailID],[ProdID],[ProdQty],[ProdPrice] FROM .[dbo].[ReportAllOrder]");
            dgvAllorder.DataSource = data;
            OrderAll = data;
            calAllorder();
        }
        void calAllorder()
        {
            int total = 0;
            foreach (DataRow item in OrderAll.Rows)
            {
                if(item["ProdQty"] != DBNull.Value && item["ProdPrice"]!=DBNull.Value)
                {
                    total += (Convert.ToInt32(item["ProdQty"].ToString()) * Convert.ToInt32(item["ProdPrice"].ToString()));
                }
            }
            Alllorderlbl.Text = total.ToString();
        }

    }
}
