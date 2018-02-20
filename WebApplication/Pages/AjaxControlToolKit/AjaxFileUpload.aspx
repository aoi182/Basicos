<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AjaxFileUpload.aspx.cs" Inherits="WebApplication.Pages.AjaxControlToolKit.AjaxFileUpload" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <script type="text/javascript">
        function closePopup() {
            document.getElementById("btnClose").click();
        }
    </script>
    
    <asp:ImageButton runat="server" ImageUrl="../../Content/images/play.ico" Width="18px" Height="18px" OnClick="OnClick"/>
    <asp:Button ID="btnShow" ClientIDMode="Static" runat="server" Text="Show Modal Popup" />

    <asp:Panel runat="server" ID="pnl" Style="display: none" CssClass="modalPopup">
        <div style="width: 800px">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:AjaxFileUpload runat="server" ID="fileupload" MaximumNumberOfFiles="1" OnUploadComplete="Save" 
                        ClearFileListAfterUpload="True" OnClientUploadComplete="closePopup"/>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <asp:Button ID="btnClose" ClientIDMode="Static" runat="server" Text="Close" />
    </asp:Panel>

    <asp:ModalPopupExtender runat="server" Enabled="True" TargetControlID="btnShow" CancelControlID="btnClose"
        PopupControlID="pnl" ID="pnl_ModalPopupExtender" BackgroundCssClass="modalBackground">
    </asp:ModalPopupExtender>
</asp:Content>