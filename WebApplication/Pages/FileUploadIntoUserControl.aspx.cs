using System;
using System.IO;
using System.Web.UI;

namespace WebApplication.Pages
{
    public partial class FileUploadIntoUserControl : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClick(object sender, ImageClickEventArgs e)
        {
            fileupload.Show();
        }

        protected void fileupload_OnSaveCompleted(object sender, string e)
        {
            string directory = Path.GetDirectoryName(e);
            string extension = Path.GetExtension(e);
            if (directory != null)
            {
                string newfilename = Path.Combine(directory, $"{"newfilename"}{extension}");

                if (File.Exists(newfilename))
                {
                    File.Delete(newfilename);
                }

                File.Move(e, newfilename);
            }
        }
    }
}