<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RepeaterDemo.aspx.cs" Inherits="WebApplication.Pages.RepeaterDemo" %>
<%@ Register Src="~/Pages/UserControls/FileUploadUc.ascx" TagPrefix="uc1" TagName="FileUploadUc" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br/>
    <asp:Button runat="server" ID="btnLoad" Text="Load" CssClass="btn btn-primary" OnClick="btnLoad_OnClick"/>
    <br/>

    <asp:UpdatePanel runat="server" ID="pnlRpt" >
        <ContentTemplate>
            <table class="table">
                <thead>
                    <tr>
                        <td colspan="3" style="color: aqua; text-align: center">My Table With Event</td>
                    </tr>
                </thead>
                <asp:Repeater runat="server" ID="rptDataInfo" OnItemCommand="rptDataInfo_OnItemCommand">
                    <HeaderTemplate>
                        <tr>
                            <td>Key</td>
                            <td>Value</td>
                            <td>Action</td>
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <asp:Literal Text='<%#  DataBinder.Eval(Container.DataItem, "Key") %>' runat="server" />
                            </td>
                            <td>
                                <asp:Literal Text='<%#  DataBinder.Eval(Container.DataItem, "Value") %>' runat="server" />
                            </td>
                            <td style="align-content: center">
                                <asp:ImageButton runat="server" ImageUrl="../Content/images/play.ico" Width="18px" Height="18px" CommandName="play"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Key") %>' />
                                <%--<asp:ImageButton runat="server" Width="18px" Height="18px" CommandName="load" ID="imgBtnLoad"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Key") %>' OnClientClick="" />--%>
                                <asp:ImageButton runat="server" Width="18px" Height="18px" CommandName="load" ID="imgBtnLoad"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Key") %>' 
                                    ImageUrl='<%# DataBinder.Eval(Container.DataItem, "Image") %>' />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>

    <asp:UpdateProgress runat="server" AssociatedUpdatePanelID="pnlRpt">
        <ProgressTemplate>
            <div id="background">
                <div id="progress">
                    <h6>
                        <p style="text-align: center"><b>Procesando Datos...</b><br />
                        </p>
                    </h6>
                </div>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>
    
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:Label runat="server"><%= DateTime.Now.ToString("G") %></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>

    <uc1:FileUploadUc runat="server" ID="fileUploadUc" Folder="UploadedFiles" OnSaveCompleted="fileUploadUc_OnSaveCompleted"/>
</asp:Content>