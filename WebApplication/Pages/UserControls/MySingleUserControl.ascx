<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MySingleUserControl.ascx.cs" Inherits="WebApplication.Pages.UserControls.MySingleUserControl" %>

<asp:UpdatePanel runat="server">
    <ContentTemplate>
        <table>
            <tr>
                <td>
                    <asp:Literal runat="server" Text="Data&nbsp;Here:" />
                </td>
                <td>
                    <asp:TextBox runat="server" TextMode="Color" ID="txtColor" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button runat="server" CssClass="btn btn-primary" Text="send" OnClick="OnClick" />
                </td>
            </tr>
        </table>
    </ContentTemplate>
</asp:UpdatePanel>