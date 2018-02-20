using System;
using System.Web.UI;

namespace WebApplication.Pages
{
    public partial class DownloadIntoAnotherWindow : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void popupDownload_OnCloseEvent(object sender, bool e)
        {
            popupDownloadExt.Hide();
        }
    }
}