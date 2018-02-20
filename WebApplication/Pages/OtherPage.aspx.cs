using System;
using System.Web.UI;
using MyClassLibrary;

namespace WebApplication.Pages
{
    public partial class OtherPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filepath = Server.MapPath(@"~\Content\shared\data.txt");
            this.SendFile(filepath);
        }
    }
}