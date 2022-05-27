using SP_POS.Pages.MemberPage;
using SP_POS.Pages.ProductPage;
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
        public static Products productPage;
        public static Member memberPage;

        public static void OpenProductPage(Panel panel)
        {
            if(productPage == null)
            {
                productPage = new Products();
                productPage.Dock = DockStyle.Fill;
                panel.Controls.Add(productPage);
            }
            productPage.BringToFront();
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
        }
    }
    
}
