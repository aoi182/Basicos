using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication.Model;

namespace WebApplication.Pages
{
    public partial class RepeaterDemo : Page
    {
        private Dictionary<string, bool> LoadedList
        {
            get
            {
                Dictionary<string, bool> dictionary = Session["cargados"] as Dictionary<string, bool>;

                if (dictionary == null)
                    Session["cargados"] = dictionary = new Dictionary<string, bool>();

                return dictionary;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        private void LoadRpt()
        {
            var list = new List<DataInfo>
            {
                new DataInfo {Key = "#5746", Value = "Red"},
                new DataInfo {Key = "#5747", Value = "Blue"},
                new DataInfo {Key = "#5748", Value = "Black"},
                new DataInfo {Key = "#5749", Value = "Green"},
                new DataInfo {Key = "#5750", Value = "Yellow"},
            };

            foreach (var l in list)
            {
                l.Image = LoadedList.ContainsKey(l.Key) ? "../Content/images/image.ico" : "../Content/images/doc.png";
            }

            rptDataInfo.DataSource = list;
            rptDataInfo.DataBind();
        }

        protected void rptDataInfo_OnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string value = e.CommandArgument.ToString();

            switch (e.CommandName)
            {
                case "play":
                    Thread.Sleep(6*1000);
                    Debug.Write("entro "+ e.CommandArgument);
                    break;
                case "load":
                    Console.WriteLine("entró " + e.CommandArgument);
                    Session["itemId"] = value;
                    fileUploadUc.Show();
                    break;
            }
        }

        protected void fileUploadUc_OnSaveCompleted(object sender, string e)
        {
            string key = Session["itemId"].ToString();
            string directory = Path.GetDirectoryName(e);
            string extension = Path.GetExtension(e);
            if (directory != null)
            {
                string newfilename = Path.Combine(directory, $"{key}{extension}");

                if (File.Exists(newfilename))
                {
                    File.Delete(newfilename);
                }

                File.Move(e, newfilename);

                if (!LoadedList.ContainsKey(key))
                    LoadedList.Add(key, true);
            }
            fileUploadUc.Hide();

            Session["itemId"] = null;
        }

        protected void btnLoad_OnClick(object sender, EventArgs e)
        {
            LoadRpt();
        }
    }
}