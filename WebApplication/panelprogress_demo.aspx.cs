using System;
using System.Threading;
using System.Web.UI;
using MyLibrary;

namespace WebApplication
{
    public partial class panelprogress_demo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClick(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            MyClassA.Method1();
        }
    }
}