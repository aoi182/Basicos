using System;
using System.IO;
using System.Web.UI;

namespace MyClassLibrary
{
    public static class MyExtensions
    {
        public static void SendFile(this Page page, string filepath)
        {
            // Create New instance of FileInfo class to get the properties of the file being downloaded
            FileInfo myfile = new FileInfo(filepath);

            // Checking if file exists
            if (myfile.Exists)
            {
                // Clear the content of the response
                page.Response.ClearContent();

                // Add the file name and attachment, which will force the open/cancel/save dialog box to show, to the header
                page.Response.AddHeader("Content-Disposition", "attachment; filename=" + myfile.Name);

                // Add the file size into the response header
                page.Response.AddHeader("Content-Length", myfile.Length.ToString());

                // Set the ContentType
                page.Response.ContentType = ReturnExtension(myfile.Extension.ToLower());

                // Write the file into the response (TransmitFile is for ASP.NET 2.0. In ASP.NET 1.1 you have to use WriteFile instead)
                page.Response.TransmitFile(myfile.FullName);

                page.Response.Flush();

                // End the response
                try
                {
                    page.Response.End();
                }
                catch (Exception exName)
                {
                    Console.WriteLine(exName);
                }
            }
        }

        private static string ReturnExtension(string fileExtension)
        {
            switch (fileExtension)
            {
                case ".htm":
                case ".html":
                case ".log":
                    return "text/HTML";
                case ".txt":
                    return "text/plain";
                case ".doc":
                    return "application/ms-word";
                case ".tiff":
                case ".tif":
                    return "image/tiff";
                case ".asf":
                    return "video/x-ms-asf";
                case ".avi":
                    return "video/avi";
                case ".zip":
                    return "application/zip";
                case ".xls":
                case ".csv":
                    return "application/vnd.ms-excel";
                case ".gif":
                    return "image/gif";
                case ".jpg":
                case "jpeg":
                    return "image/jpeg";
                case ".bmp":
                    return "image/bmp";
                case ".wav":
                    return "audio/wav";
                case ".mp3":
                    return "audio/mpeg3";
                case ".mpg":
                case "mpeg":
                    return "video/mpeg";
                case ".rtf":
                    return "application/rtf";
                case ".asp":
                    return "text/asp";
                case ".pdf":
                    return "application/pdf";
                case ".fdf":
                    return "application/vnd.fdf";
                case ".ppt":
                    return "application/mspowerpoint";
                case ".dwg":
                    return "image/vnd.dwg";
                case ".msg":
                    return "application/msoutlook";
                case ".xml":
                case ".sdxl":
                    return "application/xml";
                case ".xdp":
                    return "application/vnd.adobe.xdp+xml";
                default:
                    return "application/octet-stream";
            }
        }

        public static void Show(this Page page, string message)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "MessageBox", "<script language='javascript'>alert('" + message + "');</script>");
        }
    }
}