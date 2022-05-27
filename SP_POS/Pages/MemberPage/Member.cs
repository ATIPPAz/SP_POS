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

namespace SP_POS.Pages.MemberPage
{
    public partial class Member : UserControl
    {
        public Member()
        {
            InitializeComponent();
            SetGender();
            SetPrefix();
            SetStatus();
            Addtable();
        }
        DataTable dt = new DataTable();

        private void SetStatus()
        {
            Sql sql = new Sql();
            var data = sql.Select("Select StatusID,StatusName from [dbo].[Status]");
           /* comboType.ValueMember = "StatusID";
            comboType.DisplayMember = "StatusName";
            comboType.DataSource = data;*/
            Status.ValueMember = "StatusID";
            Status.DisplayMember = "StatusName";
            Status.DataSource = data;
        }

        private void Addtable()
        {
            Sql sql = new Sql();
            var data = sql.Select("select [CustaccID] as CustAccID,[CustID] ,[CustUsername],[Status] as CustStatus,[CustFName] as CustFname,[CustLName] as CustLname,[CustBirth],[CustPhone],[CustMail],[CustPrefix],[CustGender],[CustAddress] FROM [dbo].[CustomerData]");
            
            dgvMember.DataSource = data;
            dt = data;
        }

        private void SetPrefix()
        {
            string[] prefix = new string[] {"นาย   ","นางสาว","นาง   " };
            foreach (var item in prefix)
            {
                Prefix.Items.Add(item);
            }
        }

        private void SetGender()
        {
            
            Gender.ValueMember = "Value";
            Gender.DisplayMember = "Text";
           
          

            var items = new[] {
    new { Text = "ชาย", Value = "M " },
    new { Text = "หญิง", Value = "FM" },

};

            Gender.DataSource = items;
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvMember_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }
    }
    class comboboxvalue
    {
        public string Text { get; set; }
        public object Value { get; set; }
    }
}
