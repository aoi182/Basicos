using System;
using System.Web.UI;

namespace WebApplication.Pages
{
    public partial class ModapPopupUserControl : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mySingleUc.ChooseColor += PasoLago;
        }

        private void PasoLago(object sender, string c)
        {
            lblColor.Text = c;
            popup.Hide();
        }
    }
}