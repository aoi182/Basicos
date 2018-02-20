<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModapPopupUserControl.aspx.cs" Inherits="WebApplication.Pages.ModapPopupUserControl" %>
<%@ Register tagPrefix="uc" tagName="myUc" src="~/Pages/UserControls/MySingleUserControl.ascx" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel runat="server" ID="pnlMain">
        <ContentTemplate>
            <br/>&nbsp;
            <asp:Button runat="server" ID="btnShowUc" Text="open popup" CssClass="btn btn-primary"/>
            <asp:Panel runat="server" ID="pnlUsrCtrl" Style="display: none" CssClass="modalPopup">
                <div style="width: min-content">
                    <uc:myUc ID="mySingleUc" runat="server" />
                </div>
            </asp:Panel>
            <ajaxToolkit:ModalPopupExtender runat="server" Enabled="True" TargetControlID="btnShowUc" PopupControlID="pnlUsrCtrl" ID="popup" BackgroundCssClass="modalBackground" />

            <asp:Label runat="server" ID="lblColor" Text="non selected color"></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>