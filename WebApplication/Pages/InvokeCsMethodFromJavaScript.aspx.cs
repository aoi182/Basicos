using System;
using System.Web.Services;
using System.Web.UI;

namespace WebApplication.Pages
{
    public partial class InvokeCsMethodFromJavaScript : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string JQueryAjaxCall(string data1, string data2)
        {
            return $"{data1}-{data2}";
        }
    }
}