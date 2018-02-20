using System;
using System.Web.UI;

namespace WebApplication.Pages.UserControls
{
    public partial class MySingleUserControl : UserControl
    {
        public event EventHandler<string> ChooseColor;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClick(object sender, EventArgs e)
        {
            //System.Threading.Thread.Sleep(5 * 1000);
            string rgb = txtColor.Text;

            ChooseColor?.Invoke(sender, rgb);
        }
    }
}