<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PopupToDonload.ascx.cs" Inherits="WebApplication.Pages.UserControls.PopupToDonload" %>

<asp:UpdatePanel runat="server">
    <ContentTemplate>
        <asp:Button ID="myBtn" runat="server" Text="Click me" OnClientClick="window.open('OtherPage.aspx', 'OtherPage');" />
        <asp:Button runat="server" Text="close" OnClick="OnClick"/>
    </ContentTemplate>
</asp:UpdatePanel>