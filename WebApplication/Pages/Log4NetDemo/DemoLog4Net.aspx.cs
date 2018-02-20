using System;
using System.Web.UI;
using MyLibrary;

namespace WebApplication.Pages.Log4NetDemo
{
    public partial class DemoLog4Net : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClick(object sender, EventArgs e)
        {
            MyClassA.Method1();
        }
    }
}