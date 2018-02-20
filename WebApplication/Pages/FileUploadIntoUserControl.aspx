<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FileUploadIntoUserControl.aspx.cs" Inherits="WebApplication.Pages.FileUploadIntoUserControl" %>
<%@ Register src="~/Pages/UserControls/FileUploadUc.ascx" tagName="fileupload" tagPrefix="ucx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
    &nbsp;&nbsp;&nbsp;<asp:ImageButton runat="server" ImageUrl="~/Content/images/image.ico" Width="16px" Height="16px" OnClick="OnClick"/>
    <ucx:fileupload runat="server" ID="fileupload" Folder="UploadedFiles" OnSaveCompleted="fileupload_OnSaveCompleted"/>
</asp:Content>