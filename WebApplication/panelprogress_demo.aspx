<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="panelprogress_demo.aspx.cs" Inherits="WebApplication.panelprogress_demo" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:UpdatePanel runat="server" ID="pnlBtns">
        <ContentTemplate>
            <asp:TextBox runat="server" TextMode="Date"/>
            <asp:TextBox runat="server" TextMode="Color"/>
            <asp:TextBox runat="server" TextMode="DateTimeLocal"/>
            <asp:TextBox runat="server" TextMode="DateTime"/>
            <asp:TextBox runat="server" TextMode="Email"/>
            <asp:Button runat="server" Text="click me" OnClick="OnClick"/>
        </ContentTemplate>
    </asp:UpdatePanel>
    
    <asp:UpdateProgress runat="server" AssociatedUpdatePanelID="pnlBtns">
        <ProgressTemplate>
            <div id="background">
                <div id="progress">
                    <h6><p style="text-align: center"><b>Procesando Datos...</b><br/></p></h6>
                </div>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>

</asp:Content>