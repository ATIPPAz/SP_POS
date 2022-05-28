using SP_POS.Controls;
using SP_POS.Pages.LoginPage;
using SP_POS.Pages.MemberPage;
using SP_POS.Pages.PosPage;
using SP_POS.Pages.PosPage.Payment_Method;
using SP_POS.Pages.ProductPage;
using SP_POS.Pages.ReportPage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SP_POS.Classes
{
    public static class Route
    {
        public static PosIndex index;
        public static Products productPage;
        public static Member memberPage;
        public static Pos PosPage;
        public static Report ReportPage;
        public static Payment PaymentPage;
        public static CashPayment CashPaymentpage;
        public static CreditPayment CreditPaymentpage;
        public static TransferPayment Transferpaymentpage;
        public static LoginPage Login;
        public static bool isStartUp = true;

        public static PosIndex StartUpPage()
        {
            index = new PosIndex();
            Login = new LoginPage();
            index.Opacity = 0;
            Login.Show();
            Login.TopMost = true;
            return index;
        }
        public static void OpenIndex()
        {

            DataTable EmplyeeData = new DataTable();
            var getdata = new Sql();
            //EmplyeeData = getdata.Select(ColumnSelect: "EmpID", Table: new string[] { "Employees" }, CallTable: new string[] { "e" }, IDSelect: MiddleStore.EmpID);
           /* foreach (DataRow item in EmplyeeData.Rows)
            {
                MiddleStore.EmpRuleID = item["DeptID"].ToString();
                // MiddleStore.EmpID = 
            }*/
            index.Opacity = 1;
            index.Show();
          /*  MiddleStore.EmpRule = (MiddleStore.EmpRuleID == "D04") ? "Packing" : (MiddleStore.EmpRuleID == "D09") ? "God" : (MiddleStore.EmpRuleID == "D08") ? "Shipping" : (MiddleStore.EmpRuleID == "D01") ? "Exclusive" : (MiddleStore.EmpRuleID == "D02") ? "Finance" : (MiddleStore.EmpRuleID == "D03") ? "Warehouse" : (MiddleStore.EmpRuleID == "D05") ? "Purchase" : (MiddleStore.EmpRuleID == "D06") ? "Hr" : "";
            index.LoadMenuListBtn();*/
        }
        public static void CloseLoginForm()
        {
            Login.Close();
            Login.Dispose();
        }
        public static void CloseIndex()
        {
            index.Close();
            Application.Exit();
        }
        public static void OpenProductPage(Panel panel)
        {
            if(productPage == null)
            {
                productPage = new Products();
                productPage.Dock = DockStyle.Fill;
                panel.Controls.Add(productPage);
            }
            productPage.BringToFront();
            if (memberPage != null)
            {
                memberPage.Dispose();
                memberPage = null;
            }
            if(ReportPage != null)
            {
                ReportPage.Dispose();
                ReportPage = null;
            }
            if(PosPage != null)
            {
                PosPage.Dispose();
                PosPage = null;
            }
        }

        public static void OpenMemberPage(Panel panel)
        {
            if (memberPage == null)
            {
                memberPage = new Member();
                memberPage.Dock = DockStyle.Fill;
                panel.Controls.Add(memberPage);
            }
            memberPage.BringToFront();
            if (productPage != null)
            {
                productPage.Dispose();
                productPage = null;
            }
            if (ReportPage != null)
            {
                ReportPage.Dispose();
                ReportPage = null;
            }
            if (PosPage != null)
            {
                PosPage.Dispose();
                PosPage = null;
            }
        }
        
        public static void OpenPosPage(Panel panel)
        {
            if (PosPage == null)
            {
                PosPage = new Pos();
                PosPage.Dock = DockStyle.Fill;
                panel.Controls.Add(PosPage);
            }
            PosPage.BringToFront();
            if (productPage != null)
            {
                productPage.Dispose();
                productPage = null;
            }
            if (ReportPage != null)
            {
                ReportPage.Dispose();
                ReportPage = null;
            }
            if (memberPage != null)
            {
                memberPage.Dispose();
                memberPage = null;
            }
        }
        public static void OpenReportPage(Panel panel)
        {
            if (ReportPage == null)
            {
                ReportPage = new Report();
                ReportPage.Dock = DockStyle.Fill;
                panel.Controls.Add(ReportPage);
            }
            ReportPage.BringToFront();
            if (memberPage != null)
            {
                memberPage.Dispose();
                memberPage = null;
            }
            if (productPage != null)
            {
                productPage.Dispose();
                productPage = null;
            }
            if (PosPage != null)
            {
                PosPage.Dispose();
                PosPage = null;
            }
        }
        public static void OpenPayment(Panel panel)
        {
            PaymentPage = new Payment();
            PaymentPage.Dock = DockStyle.Fill;
            panel.Controls.Add(PaymentPage);
            PaymentPage.BringToFront();
            PosPage.SendToBack();
            if (productPage != null)
            {
                productPage.Dispose();
                productPage = null;
            }
            if (ReportPage != null)
            {
                ReportPage.Dispose();
                ReportPage = null;
            }
            if (memberPage != null)
            {
                memberPage.Dispose();
                memberPage = null;
            }
        }
        public static void OpenCashPage(Panel panel,int total, List<Body> order)
        {
            if (CashPaymentpage == null)
            {
                CashPaymentpage = new CashPayment();
                CashPaymentpage.getTotal(total, order);
                CashPaymentpage.Dock = DockStyle.Fill;
                panel.Controls.Add(CashPaymentpage);
            }
            if (CreditPaymentpage != null)
            {
                CreditPaymentpage.Dispose();
                CreditPaymentpage = null;
            }
            if (Transferpaymentpage != null)
            {
                Transferpaymentpage.Dispose();
                Transferpaymentpage = null;
            }
        }
        public static void CreateLoginPage(Form form)
        {
            Login = new LoginPage();
            isStartUp = true;
            Login.Show();
            Login.TopMost = true;
            index.Opacity = 0;
            if (form != null)
            {
                form.Close();
            }
            index.Hide();
        }
        public static void OpenCreditPage(Panel panel)
        {
            if (CreditPaymentpage == null)
            {
                CreditPaymentpage = new CreditPayment();
                CreditPaymentpage.Dock = DockStyle.Fill;
                panel.Controls.Add(CreditPaymentpage);
            }
            if (CashPaymentpage != null)
            {
                CashPaymentpage.Dispose();
                CashPaymentpage = null;
            }
            if (Transferpaymentpage != null)
            {
                Transferpaymentpage.Dispose();
                Transferpaymentpage = null;
            }
        }
        public static void OpenTransferPage(Panel panel)
        {
            if (Transferpaymentpage == null)
            {
                Transferpaymentpage = new TransferPayment();
                Transferpaymentpage.Dock = DockStyle.Fill;
                panel.Controls.Add(Transferpaymentpage);
            }
            if(CashPaymentpage != null)
            {
                CashPaymentpage.Dispose();
                CashPaymentpage = null;
            }
            if (CreditPaymentpage !=null)
            {
                CreditPaymentpage.Dispose();
                CreditPaymentpage = null;
            }
        }
        public static void BackToPos(Panel panel)
        {
            PosPage.BringToFront();
            if(PaymentPage  != null)
            {
                PaymentPage.Dispose();
                productPage = null;
            }
            if (productPage != null)
            {
                productPage.Dispose();
                productPage = null;
            }
            if (ReportPage != null)
            {
                ReportPage.Dispose();
                ReportPage = null;
            }
            if (memberPage != null)
            {
                memberPage.Dispose();
                memberPage = null;
            }
        }
    }
    
}
