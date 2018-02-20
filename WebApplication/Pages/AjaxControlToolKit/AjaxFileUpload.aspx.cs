using System;
using System.IO;
using System.Web.UI;
using AjaxControlToolkit;

namespace WebApplication.Pages.AjaxControlToolKit
{
    public partial class AjaxFileUpload : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Save(object sender, AjaxFileUploadEventArgs e)
        {
            string filename = Path.GetFileName(e.FileName);
            fileupload.SaveAs(Path.Combine(Server.MapPath("~/UploadedFiles/"), filename));
        }

        protected void OnClick(object sender, ImageClickEventArgs e)
        {
            pnl_ModalPopupExtender.Show();
        }
        
    }
}