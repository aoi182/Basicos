<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RepeaterFileUpload.aspx.cs" Inherits="WebApplication.Pages.AjaxControlToolKit.RepeaterFileUpload" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function closePopup() {
            document.getElementById("btnClose").click();
        }
    </script>
    

    <asp:Button runat="server" OnClick="OnClick2" Text="Load.." CssClass="btn btn-primary"/>

    <asp:UpdatePanel runat="server" ID="pnlRpt">
        <ContentTemplate>
            <table style="margin: auto; width: 50%" class="table table-bordered" >
                <thead>
                    <tr class="table-hover" style="text-align: center">
                        <td colspan="4">My table with event</td>
                    </tr>
                </thead>
                <asp:Repeater runat="server" ID="rptDataInfo" OnItemCommand="rptDataInfo_OnItemCommand">
                    <HeaderTemplate>
                        <tr class="table-hover">
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
                                <asp:ImageButton runat="server" ImageUrl="~/Content/images/play.ico" Width="18px" Height="18px" CommandName="play"
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Key") %>' />
                                <asp:ImageButton runat="server" Width="18px" Height="18px" CommandName="load"
                                    ImageUrl='<%# DataBinder.Eval(Container.DataItem, "Image") %>' 
                                    CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Key") %>' OnClick="OnClick"/>
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
                        <p style="text-align: center"><b>Procesando Datos...</b><br /></p>
                    </h6>
                </div>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>
    
    <asp:Button ID="btnShow" ClientIDMode="Static" runat="server" Text="Show Modal Popup" style="display: none" />
    
    <asp:Panel runat="server" ID="pnl" Style="display: none" CssClass="modalPopup">
        <div style="width: 800px">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <ajaxToolkit:AjaxFileUpload runat="server" ID="fileupload" MaximumNumberOfFiles="1" OnUploadComplete="Save"
                        ClearFileListAfterUpload="True" OnClientUploadComplete="closePopup" />
                </ContentTemplate>
            </asp:UpdatePanel>
            <br/>
            <div style="align-content: center"><asp:Button ID="btnClose" ClientIDMode="Static" runat="server" Text="Close" CssClass="btn-primary"/></div>
        </div>
    </asp:Panel>
    <ajaxToolkit:ModalPopupExtender runat="server" Enabled="True" TargetControlID="btnShow" CancelControlID="btnClose"
        PopupControlID="pnl" ID="pnl_ModalPopupExtender" BackgroundCssClass="modalBackground">
    </ajaxToolkit:ModalPopupExtender>
    
    
</asp:Content>