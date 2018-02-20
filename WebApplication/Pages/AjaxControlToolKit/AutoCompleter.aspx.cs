using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;

namespace WebApplication.Pages.AjaxControlToolKit
{
    public partial class AutoCompleter : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        [ScriptMethod]
        public static List<string> GetCountries(string prefixText)
        {
            List<string> list = new List<string>
            {
                "Colombia",
                "Argentina",
                "Brasil",
                "Perú",
                "México",
                "Panamá",
                "Bolivia",
                "Chile",
                "Venezuel",
                "Ecuador",
                "Uruguay",
                "Paraguay"
            };

            return list.Where(q => q.ToLower().Contains(prefixText.ToLower())).ToList();
        }
    }
}