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

namespace SP_POS
{
    public partial class PosIndex : Form
    {
        public PosIndex()
        {
            InitializeComponent();
        }

        private void PosIndex_Load(object sender, EventArgs e)
        {
          
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            ProductBtn.BackColor = Color.FromArgb(222, 222, 222);
            ReportBtn.BackColor = Color.FromArgb(248, 248, 249);
            Memberbtn.BackColor = Color.FromArgb(248, 248, 249);
            PosBtn.BackColor = Color.FromArgb(248, 248, 249);
            Route.OpenProductPage(DisplayPanel);
        }

        private void MemberBtn_Click(object sender, EventArgs e)
        {
            Memberbtn.BackColor = Color.FromArgb(222, 222, 222);
            ProductBtn.BackColor = Color.FromArgb(248, 248, 249);
            ReportBtn.BackColor = Color.FromArgb(248, 248, 249);
            PosBtn.BackColor = Color.FromArgb(248, 248, 249);
            Route.OpenMemberPage(DisplayPanel);
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            ReportBtn.BackColor = Color.FromArgb(222, 222, 222);
            ProductBtn.BackColor = Color.FromArgb(248, 248, 249);
            PosBtn.BackColor = Color.FromArgb(248, 248, 249);
            Memberbtn.BackColor = Color.FromArgb(248, 248, 249);
        }

        private void PosBtn_Click(object sender, EventArgs e)
        {
            PosBtn.BackColor = Color.FromArgb(222, 222, 222);
            ProductBtn.BackColor = Color.FromArgb(248, 248, 249);
            ReportBtn.BackColor = Color.FromArgb(248, 248, 249);
            Memberbtn.BackColor = Color.FromArgb(248, 248, 249);
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimunBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PosBtn_Enter(object sender, EventArgs e)
        {
            PosBtn.BackColor = Color.FromArgb(220, 220, 220);
        }
    }
}
