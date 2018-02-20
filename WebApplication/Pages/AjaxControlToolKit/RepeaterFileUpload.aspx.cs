using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using WebApplication.Model;

namespace WebApplication.Pages.AjaxControlToolKit
{
    public partial class RepeaterFileUpload : Page
    {
        private Dictionary<string, bool> LoadedList
        {
            get
            {
                Dictionary<string, bool> dictionary = Session["cargados_1212"] as Dictionary<string, bool>;

                if (dictionary == null)
                    Session["cargados_1212"] = dictionary = new Dictionary<string, bool>();

                return dictionary;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

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
                l.Image = LoadedList.ContainsKey(l.Key) ? "~/Content/images/image.ico" : "~/Content/images/doc.png";
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
                    Thread.Sleep(6 * 1000);
                    Console.WriteLine(value);
                    break;
                case "load":
                    Session["itemId"] = e.CommandArgument.ToString();
                    break;
            }
        }

        protected void Save(object sender, AjaxFileUploadEventArgs e)
        {
            string id = Session["itemId"].ToString();
            string filename = $"{id}{Path.GetExtension(e.FileName)}";
            fileupload.SaveAs(Path.Combine(Server.MapPath("~/UploadedFiles/"), filename));
            if (!LoadedList.ContainsKey(id))
                LoadedList.Add(id, true);

            LoadRpt();
        }

        protected void OnClick(object sender, ImageClickEventArgs e)
        {
            pnl_ModalPopupExtender.Show();
        }

        protected void OnClick2(object sender, EventArgs e)
        {
            LoadRpt();
        }
    }
}