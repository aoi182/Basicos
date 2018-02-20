<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DownloadIntoAnotherWindow.aspx.cs" Inherits="WebApplication.Pages.DownloadIntoAnotherWindow" %>
<%@ Register src="UserControls/PopupToDonload.ascx" tagName="PopupToDownload" tagPrefix="uc"%>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/><br/>
    <div style="text-align: center">
        <asp:Button runat="server" ID="btnShowPopupDownload" Text="popup to dolwnload" CssClass="btn btn-info"/>
    </div>

    <asp:Panel runat="server" ID="pnlPopupDownload">
        <uc:PopupToDownload ID="popupDownload" runat="server" OnCloseEvent="popupDownload_OnCloseEvent"/>
    </asp:Panel>

    <ajaxToolkit:ModalPopupExtender runat="server" ID="popupDownloadExt" TargetControlID="btnShowPopupDownload" 
        PopupControlID="pnlPopupDownload" BackgroundCssClass="modalBackground"/>

</asp:Content>