using System;
using System.Web.UI;

namespace WebApplication.Pages.UserControls
{
    public partial class PopupToDonload : UserControl
    {
        public event EventHandler<bool> CloseEvent;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClick(object sender, EventArgs e)
        {
            CloseEvent?.Invoke(sender, true);
        }
    }
}