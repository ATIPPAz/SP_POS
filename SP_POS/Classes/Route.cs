﻿using SP_POS.Pages.MemberPage;
using SP_POS.Pages.PosPage;
using SP_POS.Pages.ProductPage;
using SP_POS.Pages.ReportPage;
using System;
using System.Collections.Generic;
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
        public static PosIndex StartUpPage()
        {
            if(index == null)
            {
                index = new PosIndex();
                index.Show();
            }
            return index;
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
