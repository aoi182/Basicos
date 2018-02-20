using System;
using System.IO;
using System.Web.UI;
using AjaxControlToolkit;

namespace WebApplication.Pages.UserControls
{
    public partial class FileUploadUc : UserControl
    {
        public event EventHandler<string> SaveCompleted;

        public string Folder { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Save(object sender, AjaxFileUploadEventArgs e)
        {
            string fullPath = Path.Combine(Server.MapPath("~/" + Folder + "/"), e.FileName);
            fileupload.SaveAs(fullPath);

            SaveCompleted?.Invoke(null, fullPath);
        }
        
        public void Show()
        {
            pnlModalPopupExtender.Show();
        }

        public void Hide()
        {
            pnlModalPopupExtender.Hide();
        }
    }
}