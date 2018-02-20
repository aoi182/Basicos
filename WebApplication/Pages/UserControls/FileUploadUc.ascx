<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FileUploadUc.ascx.cs" Inherits="WebApplication.Pages.UserControls.FileUploadUc" %>

<script type="text/javascript">
    function closePopup() {
        document.getElementById("btnClose").click();
    }
</script>

<asp:Button ID="btnShow" ClientIDMode="Static" runat="server" Text="Show Modal Popup" Style="display: none" />
<asp:Panel runat="server" ID="pnl" Style="display: none" CssClass="modalPopup">
    <div style="width: 800px">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <ajaxToolkit:AjaxFileUpload runat="server" ID="fileupload" MaximumNumberOfFiles="1" OnUploadComplete="Save"
                    ClearFileListAfterUpload="True" OnClientUploadComplete="closePopup" />
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <div style="align-content: center">
            <asp:Button ID="btnClose" ClientIDMode="Static" runat="server" Text="Close" CssClass="btn btn-primary" />
        </div>
    </div>
</asp:Panel>
<ajaxToolkit:ModalPopupExtender runat="server" Enabled="True" TargetControlID="btnShow" CancelControlID="btnClose"
    PopupControlID="pnl" ID="pnlModalPopupExtender" BackgroundCssClass="modalBackground">
</ajaxToolkit:ModalPopupExtender>